// <autogenerated />
#pragma warning disable 618  // Ignore obsolete members warnings
#pragma warning disable 105  // Ignore duplicate namespaces
#pragma warning disable 1591 // Ignore missing XML comment warnings
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Uno.UI;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Documents;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Shapes;
using Windows.UI.Text;
using Uno.Extensions;
using Uno;
using UnoSample.Droid;

#if __ANDROID__
using _View = Android.Views.View;
#elif __IOS__
using _View = UIKit.UIView;
#elif __MACOS__
using _View = AppKit.NSView;
#elif __WASM__
using _View = Windows.UI.Xaml.UIElement;
#elif NET461
using _View = Windows.UI.Xaml.UIElement;
#endif

namespace UnoSample.Droid
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class GlobalStaticResources
	{
		// Source ..\..\..\..\..\..\..\UnoSample.Shared\App.xaml (Line 8:10)
		public static global::Windows.UI.Color MainColor { get; } = 
		global::Windows.UI.ColorHelper.FromARGB(255, 235, 64, 52)/* Windows.UI.Color/Windows.UI.Color, #eb4034, /_UnknownContent */		;
		// Source ..\..\..\..\..\..\..\UnoSample.Shared\App.xaml (Line 9:10)
		public static global::Windows.UI.Color TitleColor { get; } = 
		global::Windows.UI.ColorHelper.FromARGB(255, 255, 255, 255)/* Windows.UI.Color/Windows.UI.Color, #ffffff, /_UnknownContent */		;
		// Source ..\..\..\..\..\..\..\UnoSample.Shared\App.xaml (Line 11:10)
		private static bool _TextBoxBaseInitialized = false;
		private static global::Windows.UI.Xaml.Style __TextBoxBaseBackingField;

		public static global::Windows.UI.Xaml.Style TextBoxBase
		{
			get
			{
				if(!_TextBoxBaseInitialized)
				{
					__TextBoxBaseBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.Control))
						{
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Control.BorderBrushProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Media.Brush), (global::Windows.UI.Xaml.Application.Current.Resources["MainColor"] ?? throw new InvalidOperationException("The resource MainColor cannot be found")))
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Control.HeightProperty, (double)50d/* double/double, 50, Setter/Value */),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Control.ForegroundProperty, (Windows.UI.Xaml.Media.Brush)SolidColorBrushHelper.FromARGB(255, 138, 138, 138)/* Windows.UI.Xaml.Media.Brush/Windows.UI.Xaml.Media.Brush, #8a8a8a, Setter/Value */),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Control.FontSizeProperty, (double)18d/* double/double, 18, Setter/Value */),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Control.MarginProperty, (Windows.UI.Xaml.Thickness)new global::Windows.UI.Xaml.Thickness(5)/* Windows.UI.Xaml.Thickness/Windows.UI.Xaml.Thickness, 5, Setter/Value */),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Control.FontFamilyProperty, (Windows.UI.Xaml.Media.FontFamily)new Windows.UI.Xaml.Media.FontFamily("ms-appx:///Assets/Fonts/Righteous-Regular.ttf#Righteous")/* Windows.UI.Xaml.Media.FontFamily/Windows.UI.Xaml.Media.FontFamily, ms-appx:///Assets/Fonts/Righteous-Regular.ttf#Righteous, Setter/Value */),
							}
						}
						;
					_TextBoxBaseInitialized = true;
				}
				return __TextBoxBaseBackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\UnoSample.Shared\App.xaml (Line 20:10)
		private static bool _TextBoxDefaultInitialized = false;
		private static global::Windows.UI.Xaml.Style __TextBoxDefaultBackingField;

		public static global::Windows.UI.Xaml.Style TextBoxDefault
		{
			get
			{
				if(!_TextBoxDefaultInitialized)
				{
					__TextBoxDefaultBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.TextBox))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)(global::Windows.UI.Xaml.Application.Current.Resources["TextBoxBase"] ?? throw new InvalidOperationException("The resource TextBoxBase cannot be found")),
							Setters = 
							{
							}
						}
						;
					_TextBoxDefaultInitialized = true;
				}
				return __TextBoxDefaultBackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\UnoSample.Shared\App.xaml (Line 24:10)
		private static bool _PasswordBoxDefaultInitialized = false;
		private static global::Windows.UI.Xaml.Style __PasswordBoxDefaultBackingField;

		public static global::Windows.UI.Xaml.Style PasswordBoxDefault
		{
			get
			{
				if(!_PasswordBoxDefaultInitialized)
				{
					__PasswordBoxDefaultBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.PasswordBox))
						{
							BasedOn = (global::Windows.UI.Xaml.Style)(global::Windows.UI.Xaml.Application.Current.Resources["TextBoxBase"] ?? throw new InvalidOperationException("The resource TextBoxBase cannot be found")),
							Setters = 
							{
							}
						}
						;
					_PasswordBoxDefaultInitialized = true;
				}
				return __PasswordBoxDefaultBackingField;
			}
		}

		// Source ..\..\..\..\..\..\..\UnoSample.Shared\App.xaml (Line 28:10)
		private static bool _ButtomMainInitialized = false;
		private static global::Windows.UI.Xaml.Style __ButtomMainBackingField;

		public static global::Windows.UI.Xaml.Style ButtomMain
		{
			get
			{
				if(!_ButtomMainInitialized)
				{
					__ButtomMainBackingField = 
						new global::Windows.UI.Xaml.Style(typeof(global::Windows.UI.Xaml.Controls.Button))
						{
							Setters = 
							{
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Button.BackgroundProperty, () => (Windows.UI.Xaml.Media.Brush)
								(Windows.UI.Xaml.Media.Brush)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Media.Brush), (global::Windows.UI.Xaml.Application.Current.Resources["MainColor"] ?? throw new InvalidOperationException("The resource MainColor cannot be found")))
								),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Button.ForegroundProperty, (Windows.UI.Xaml.Media.Brush)SolidColorBrushHelper.White/* Windows.UI.Xaml.Media.Brush/Windows.UI.Xaml.Media.Brush, White, Setter/Value */),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Button.HeightProperty, (double)50d/* double/double, 50, Setter/Value */),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Button.FontSizeProperty, (double)18d/* double/double, 18, Setter/Value */),
								new global::Windows.UI.Xaml.Setter(global::Windows.UI.Xaml.Controls.Button.FontFamilyProperty, (Windows.UI.Xaml.Media.FontFamily)new Windows.UI.Xaml.Media.FontFamily("ms-appx:///Assets/Fonts/Righteous-Regular.ttf#Righteous")/* Windows.UI.Xaml.Media.FontFamily/Windows.UI.Xaml.Media.FontFamily, ms-appx:///Assets/Fonts/Righteous-Regular.ttf#Righteous, Setter/Value */),
							}
						}
						;
					_ButtomMainInitialized = true;
				}
				return __ButtomMainBackingField;
			}
		}

		static partial void RegisterResources_App_acf1a312807149e49d385779321152af()
		{
			AddResolver(name =>
			{
				switch(name)
				{
					case "MainColor":
						return MainColor;
					case "TitleColor":
						return TitleColor;
					case "TextBoxBase":
						return TextBoxBase;
					case "TextBoxDefault":
						return TextBoxDefault;
					case "PasswordBoxDefault":
						return PasswordBoxDefault;
					case "ButtomMain":
						return ButtomMain;
				}
				return null;
			}
			);
		}
	}
}
namespace UnoSample.Droid.__Resources
{
}
namespace UnoSample
{
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0056", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0058", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV1003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV0085", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2001", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2003", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2004", Justification="Generated code")]
	[global::System.Diagnostics.CodeAnalysis.SuppressMessage("nventive.Usage", "NV2005", Justification="Generated code")]
	public sealed partial class App : Windows.UI.Xaml.Application
	{
		private void InitializeComponent()
		{
			global::Uno.UI.RemoteControl.RemoteControlClient.Initialize(GetType());
			global::Windows.UI.Xaml.GenericStyles.Initialize();
			global::Windows.UI.Xaml.ResourceDictionary.DefaultResolver = global::UnoSample.Droid.GlobalStaticResources.FindResource;
			global::Windows.ApplicationModel.Resources.ResourceLoader.DefaultLanguage = "en-US";
			global::Windows.ApplicationModel.Resources.ResourceLoader.AddLookupAssembly(GetType().Assembly);
			global::Windows.ApplicationModel.Resources.ResourceLoader.AddLookupAssembly(global::System.Reflection.Assembly.Load("Uno.UI, Version=255.255.255.255, Culture=neutral, PublicKeyToken=null"));
			global::UnoSample.Droid.GlobalStaticResources.Initialize();
			global::Uno.UI.DataBinding.BindableMetadata.Provider = new global::UnoSample.Droid.BindableMetadataProvider();
			#if __ANDROID__
			global::Uno.Helpers.DrawableHelper.Drawables = typeof(global::UnoSample.Droid.Resource.Drawable);
			#endif
			// Source ..\..\..\..\..\..\..\UnoSample.Shared\App.xaml (Line 1:2)
			
			this
			.Apply((c0 => 
			{
				// Source C:\Users\dudup.000\Desktop\Projetos\UnoSample\UnoSample\UnoSample.Shared\App.xaml (Line 1:2)
				
				// WARNING Property c0.base does not exist on {http://schemas.microsoft.com/winfx/2006/xaml/presentation}Application, the namespace is http://www.w3.org/XML/1998/namespace. This error was considered irrelevant by the XamlFileGenerator
			}
			))
			;
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace UnoSample.Droid
{
	static class App_acf1a312807149e49d385779321152afXamlApplyExtensions
	{
	}
}
