// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace CustomizeAnimation {
	
	
	// Should subclass MonoMac.AppKit.NSView
	[MonoMac.Foundation.Register("BaseView")]
	public partial class BaseView {
	}
	
	// Should subclass MonoMac.AppKit.NSWindow
	[MonoMac.Foundation.Register("MainWindow")]
	public partial class MainWindow {
	}
	
	// Should subclass MonoMac.AppKit.NSWindowController
	[MonoMac.Foundation.Register("MainWindowController")]
	public partial class MainWindowController {
		
		private BaseView __mt_myView;
		
		#pragma warning disable 0169
		[MonoMac.Foundation.Export("makeDefault:")]
		partial void makeDefault (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Export("makeFast:")]
		partial void makeFast (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Export("makeSlow:")]
		partial void makeSlow (MonoMac.AppKit.NSButton sender);

		[MonoMac.Foundation.Connect("myView")]
		private BaseView myView {
			get {
				this.__mt_myView = ((BaseView)(this.GetNativeField("myView")));
				return this.__mt_myView;
			}
			set {
				this.__mt_myView = value;
				this.SetNativeField("myView", value);
			}
		}
	}
}
