
// This file has been generated by the GUI designer. Do not modify.
namespace MonoDevelop.MacDev.PlistEditor
{
	public partial class PListEditorWidget
	{
		private global::Gtk.Notebook notebook1;
		private global::Gtk.ScrolledWindow scrolledwindow1;
		private global::Gtk.VBox vbox2;
		private global::MonoDevelop.MacDev.PlistEditor.MacExpander iosApplicationTargetContainer;
		private global::MonoDevelop.MacDev.PlistEditor.MacExpander iPhoneDeploymentInfoContainer;
		private global::MonoDevelop.MacDev.PlistEditor.MacExpander iPadDeploymentInfoContainer;
		private global::Gtk.Label label1;
		private global::Gtk.ScrolledWindow scrolledwindow2;
		private global::Gtk.VBox vbox3;
		private global::MonoDevelop.MacDev.PlistEditor.MacExpander customTargetPropertiesContainer;
		private global::MonoDevelop.MacDev.PlistEditor.MacExpander documentTypeExpander;
		private global::MonoDevelop.MacDev.PlistEditor.MacExpander exportedUTIExpander;
		private global::MonoDevelop.MacDev.PlistEditor.MacExpander importedUTIExpander;
		private global::MonoDevelop.MacDev.PlistEditor.MacExpander urlTypeExpander;
		private global::Gtk.Label label2;
		
		protected virtual void Build ()
		{
			global::Stetic.Gui.Initialize (this);
			// Widget MonoDevelop.MacDev.PlistEditor.PListEditorWidget
			global::Stetic.BinContainer.Attach (this);
			this.Name = "MonoDevelop.MacDev.PlistEditor.PListEditorWidget";
			// Container child MonoDevelop.MacDev.PlistEditor.PListEditorWidget.Gtk.Container+ContainerChild
			this.notebook1 = new global::Gtk.Notebook ();
			this.notebook1.CanFocus = true;
			this.notebook1.Name = "notebook1";
			this.notebook1.CurrentPage = 1;
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.scrolledwindow1 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow1.CanFocus = true;
			this.scrolledwindow1.Name = "scrolledwindow1";
			this.scrolledwindow1.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow1.Gtk.Container+ContainerChild
			global::Gtk.Viewport w1 = new global::Gtk.Viewport ();
			w1.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport.Gtk.Container+ContainerChild
			this.vbox2 = new global::Gtk.VBox ();
			this.vbox2.Name = "vbox2";
			// Container child vbox2.Gtk.Box+BoxChild
			this.iosApplicationTargetContainer = new global::MonoDevelop.MacDev.PlistEditor.MacExpander ();
			this.iosApplicationTargetContainer.CanFocus = true;
			this.iosApplicationTargetContainer.Name = "iosApplicationTargetContainer";
			this.iosApplicationTargetContainer.ContentLabel = "iOS Application Target";
			this.iosApplicationTargetContainer.Expanded = false;
			this.iosApplicationTargetContainer.Expandable = false;
			this.vbox2.Add (this.iosApplicationTargetContainer);
			global::Gtk.Box.BoxChild w2 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.iosApplicationTargetContainer]));
			w2.Position = 0;
			w2.Expand = false;
			w2.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.iPhoneDeploymentInfoContainer = new global::MonoDevelop.MacDev.PlistEditor.MacExpander ();
			this.iPhoneDeploymentInfoContainer.CanFocus = true;
			this.iPhoneDeploymentInfoContainer.Name = "iPhoneDeploymentInfoContainer";
			this.iPhoneDeploymentInfoContainer.ContentLabel = "iPhone / iPod Deployment Info";
			this.iPhoneDeploymentInfoContainer.Expanded = false;
			this.iPhoneDeploymentInfoContainer.Expandable = true;
			this.vbox2.Add (this.iPhoneDeploymentInfoContainer);
			global::Gtk.Box.BoxChild w3 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.iPhoneDeploymentInfoContainer]));
			w3.Position = 1;
			w3.Expand = false;
			w3.Fill = false;
			// Container child vbox2.Gtk.Box+BoxChild
			this.iPadDeploymentInfoContainer = new global::MonoDevelop.MacDev.PlistEditor.MacExpander ();
			this.iPadDeploymentInfoContainer.CanFocus = true;
			this.iPadDeploymentInfoContainer.Name = "iPadDeploymentInfoContainer";
			this.iPadDeploymentInfoContainer.ContentLabel = "iPad Deployment Info";
			this.iPadDeploymentInfoContainer.Expanded = false;
			this.iPadDeploymentInfoContainer.Expandable = true;
			this.vbox2.Add (this.iPadDeploymentInfoContainer);
			global::Gtk.Box.BoxChild w4 = ((global::Gtk.Box.BoxChild)(this.vbox2 [this.iPadDeploymentInfoContainer]));
			w4.Position = 2;
			w4.Expand = false;
			w4.Fill = false;
			w1.Add (this.vbox2);
			this.scrolledwindow1.Add (w1);
			this.notebook1.Add (this.scrolledwindow1);
			// Notebook tab
			this.label1 = new global::Gtk.Label ();
			this.label1.Name = "label1";
			this.label1.LabelProp = global::Mono.Unix.Catalog.GetString ("Summary");
			this.notebook1.SetTabLabel (this.scrolledwindow1, this.label1);
			this.label1.ShowAll ();
			// Container child notebook1.Gtk.Notebook+NotebookChild
			this.scrolledwindow2 = new global::Gtk.ScrolledWindow ();
			this.scrolledwindow2.CanFocus = true;
			this.scrolledwindow2.Name = "scrolledwindow2";
			this.scrolledwindow2.ShadowType = ((global::Gtk.ShadowType)(1));
			// Container child scrolledwindow2.Gtk.Container+ContainerChild
			global::Gtk.Viewport w8 = new global::Gtk.Viewport ();
			w8.ShadowType = ((global::Gtk.ShadowType)(0));
			// Container child GtkViewport1.Gtk.Container+ContainerChild
			this.vbox3 = new global::Gtk.VBox ();
			this.vbox3.Name = "vbox3";
			// Container child vbox3.Gtk.Box+BoxChild
			this.customTargetPropertiesContainer = new global::MonoDevelop.MacDev.PlistEditor.MacExpander ();
			this.customTargetPropertiesContainer.CanFocus = true;
			this.customTargetPropertiesContainer.Name = "customTargetPropertiesContainer";
			this.customTargetPropertiesContainer.ContentLabel = "Custom iOS Target Properties";
			this.customTargetPropertiesContainer.Expanded = false;
			this.customTargetPropertiesContainer.Expandable = false;
			this.vbox3.Add (this.customTargetPropertiesContainer);
			global::Gtk.Box.BoxChild w9 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.customTargetPropertiesContainer]));
			w9.Position = 0;
			w9.Expand = false;
			w9.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.documentTypeExpander = new global::MonoDevelop.MacDev.PlistEditor.MacExpander ();
			this.documentTypeExpander.CanFocus = true;
			this.documentTypeExpander.Name = "documentTypeExpander";
			this.documentTypeExpander.ContentLabel = "Document Types";
			this.documentTypeExpander.Expanded = false;
			this.documentTypeExpander.Expandable = true;
			this.vbox3.Add (this.documentTypeExpander);
			global::Gtk.Box.BoxChild w10 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.documentTypeExpander]));
			w10.Position = 1;
			w10.Expand = false;
			w10.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.exportedUTIExpander = new global::MonoDevelop.MacDev.PlistEditor.MacExpander ();
			this.exportedUTIExpander.CanFocus = true;
			this.exportedUTIExpander.Name = "exportedUTIExpander";
			this.exportedUTIExpander.ContentLabel = "Exported UTIs";
			this.exportedUTIExpander.Expanded = false;
			this.exportedUTIExpander.Expandable = true;
			this.vbox3.Add (this.exportedUTIExpander);
			global::Gtk.Box.BoxChild w11 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.exportedUTIExpander]));
			w11.Position = 2;
			w11.Expand = false;
			w11.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.importedUTIExpander = new global::MonoDevelop.MacDev.PlistEditor.MacExpander ();
			this.importedUTIExpander.CanFocus = true;
			this.importedUTIExpander.Name = "importedUTIExpander";
			this.importedUTIExpander.ContentLabel = "Imported UTIs";
			this.importedUTIExpander.Expanded = false;
			this.importedUTIExpander.Expandable = true;
			this.vbox3.Add (this.importedUTIExpander);
			global::Gtk.Box.BoxChild w12 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.importedUTIExpander]));
			w12.Position = 3;
			w12.Expand = false;
			w12.Fill = false;
			// Container child vbox3.Gtk.Box+BoxChild
			this.urlTypeExpander = new global::MonoDevelop.MacDev.PlistEditor.MacExpander ();
			this.urlTypeExpander.CanFocus = true;
			this.urlTypeExpander.Name = "urlTypeExpander";
			this.urlTypeExpander.ContentLabel = "URL Types";
			this.urlTypeExpander.Expanded = false;
			this.urlTypeExpander.Expandable = true;
			this.vbox3.Add (this.urlTypeExpander);
			global::Gtk.Box.BoxChild w13 = ((global::Gtk.Box.BoxChild)(this.vbox3 [this.urlTypeExpander]));
			w13.Position = 4;
			w13.Expand = false;
			w13.Fill = false;
			w8.Add (this.vbox3);
			this.scrolledwindow2.Add (w8);
			this.notebook1.Add (this.scrolledwindow2);
			global::Gtk.Notebook.NotebookChild w16 = ((global::Gtk.Notebook.NotebookChild)(this.notebook1 [this.scrolledwindow2]));
			w16.Position = 1;
			// Notebook tab
			this.label2 = new global::Gtk.Label ();
			this.label2.Name = "label2";
			this.label2.LabelProp = global::Mono.Unix.Catalog.GetString ("Info");
			this.notebook1.SetTabLabel (this.scrolledwindow2, this.label2);
			this.label2.ShowAll ();
			this.Add (this.notebook1);
			if ((this.Child != null)) {
				this.Child.ShowAll ();
			}
			this.Show ();
		}
	}
}
