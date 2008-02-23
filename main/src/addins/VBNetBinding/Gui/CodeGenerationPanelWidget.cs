//
// CodeGenerationPanelWidget.cs
//
// Author:
//   Mike Krüger <mkrueger@novell.com>
//
// Copyright (C) 2008 Novell, Inc (http://www.novell.com)
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//

using System;

using MonoDevelop.Projects;
using MonoDevelop.Projects.Parser;
using MonoDevelop.Projects.Text;
using MonoDevelop.Core.Gui.Dialogs;
using MonoDevelop.Core;
using Mono.Addins;
using MonoDevelop.Components;
using VBBinding;

namespace MonoDevelop.VBNetBinding
{
	public partial class CodeGenerationPanelWidget : Gtk.Bin
	{
		DotNetProject              project;
		DotNetProjectConfiguration config;
		VBCompilerParameters       parameters;
		
		public CodeGenerationPanelWidget (Properties customizationObject)
		{
			this.Build();
			
			Gtk.ListStore store = new Gtk.ListStore (typeof (string));
			store.AppendValues (GettextCatalog.GetString ("Executable"));
			store.AppendValues (GettextCatalog.GetString ("Library"));
			store.AppendValues (GettextCatalog.GetString ("Executable with GUI"));
			store.AppendValues (GettextCatalog.GetString ("Module")); 
			
			compileTargetCombo.Model = store;
			classListStore = new Gtk.ListStore (typeof(string));
			mainClassEntry.Model = classListStore;
			mainClassEntry.TextColumn = 0;
			
			project = customizationObject.Get<DotNetProject> ("Project");
			if (project == null) {
				MonoDevelop.Ide.Gui.IdeApp.Services.MessageService.ShowError ("project == null. In CodeGenerationPanelWidget constructor (VB.NET binding).");
				return;
			}
			this.config = customizationObject.Get<DotNetProjectConfiguration> ("Config");
			if (config == null) {
				MonoDevelop.Ide.Gui.IdeApp.Services.MessageService.ShowError ("config == null. In CodeGenerationPanelWidget constructor (VB.NET binding).");
				return;
			}
			this.parameters = (VBCompilerParameters)config.CompilationParameters;
			if (parameters == null) {
				MonoDevelop.Ide.Gui.IdeApp.Services.MessageService.ShowError ("parameters == null. In CodeGenerationPanelWidget constructor (VB.NET binding).");
				return;
			}
			FillClasses ();
			
			Gtk.CellRendererText cr = new Gtk.CellRendererText ();
			compileTargetCombo.PackStart (cr, true);
			compileTargetCombo.AddAttribute (cr, "text", 0);
			compileTargetCombo.Active = (int)config.CompileTarget;
			compileTargetCombo.Changed += new EventHandler (OnTargetChanged);
			
			symbolsEntry.Text = parameters.DefineSymbols;
			mainClassEntry.Entry.Text = parameters.MainClass;
			
			generateOverflowChecksCheckButton.Active = parameters.GenerateOverflowChecks;
			allowUnsafeCodeCheckButton.Active = parameters.UnsafeCode;
			enableOptimizationCheckButton.Active = parameters.Optimize;
			
			warningsAsErrorsCheckButton.Active = !config.RunWithWarnings;
			warningLevelSpinButton.Value = parameters.WarningLevel;
			additionalArgsEntry.Text = parameters.AdditionalParameters;
		}
		
		public bool StorePanelContents ()
		{
			parameters.DefineSymbols = symbolsEntry.Text;
			parameters.MainClass = mainClassEntry.Entry.Text;
			
			parameters.GenerateOverflowChecks = generateOverflowChecksCheckButton.Active;
			parameters.UnsafeCode = allowUnsafeCodeCheckButton.Active;
			parameters.Optimize = enableOptimizationCheckButton.Active;
			
			config.RunWithWarnings = !warningsAsErrorsCheckButton.Active;
			parameters.WarningLevel = (int)warningLevelSpinButton.Value;
			parameters.AdditionalParameters = additionalArgsEntry.Text;
			return true;
		}
		
		void OnTargetChanged (object s, EventArgs a)
		{
			mainClassEntry.Sensitive = (CompileTarget) compileTargetCombo.Active == CompileTarget.Library;
		}
		
		Gtk.ListStore classListStore;
		void FillClasses ()
		{
			try {
				IParserContext ctx = MonoDevelop.Ide.Gui.IdeApp.ProjectOperations.ParserDatabase.GetProjectParserContext (project);
				foreach (IClass c in ctx.GetProjectContents ()) {
					if (c.Methods == null) 
						continue;
					foreach (IMethod m in c.Methods) {
						System.Console.WriteLine (m);
						if (m.IsStatic && m.Name.ToUpper () == "MAIN")
							classListStore.AppendValues (c.FullyQualifiedName);
					}
				}
			} catch (Exception) {
			}
		}
	}
}
