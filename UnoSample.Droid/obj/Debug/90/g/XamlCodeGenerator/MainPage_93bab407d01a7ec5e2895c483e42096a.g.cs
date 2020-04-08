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
	public sealed partial class MainPage : Windows.UI.Xaml.Controls.Page
	{
		private void InitializeComponent()
		{
			var nameScope = new global::Windows.UI.Xaml.NameScope();
			NameScope.SetNameScope(this, nameScope);
			// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 1:2)
			Content = 			new global::Windows.UI.Xaml.Controls.Grid
			{
				Width = 320d/* double/, 320, Grid/Width */,
				RowDefinitions = 
				{
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(1f, Windows.UI.Xaml.GridUnitType.Star)/* Windows.UI.Xaml.GridLength/, *, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 12:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(400f, Windows.UI.Xaml.GridUnitType.Pixel)/* Windows.UI.Xaml.GridLength/, 400, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 13:14)
					}
					,
					new global::Windows.UI.Xaml.Controls.RowDefinition
					{
						Height = new Windows.UI.Xaml.GridLength(100f, Windows.UI.Xaml.GridUnitType.Pixel)/* Windows.UI.Xaml.GridLength/, 100, RowDefinition/Height */,
						// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 14:14)
					}
					,
				}
				,
				// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 10:6)
				Children = 
				{
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						Padding = new global::Windows.UI.Xaml.Thickness(10)/* Windows.UI.Xaml.Thickness/, 10, StackPanel/Padding */,
						Margin = new global::Windows.UI.Xaml.Thickness(0,20,0,0)/* Windows.UI.Xaml.Thickness/, 0,20,0,0, StackPanel/Margin */,
						// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 17:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								Text = "Well"/* string/, Well, TextBlock/Text */,
								FontSize = 38d/* double/, 38, TextBlock/FontSize */,
								FontFamily = new Windows.UI.Xaml.Media.FontFamily("ms-appx:///Assets/Fonts/Righteous-Regular.ttf#Righteous")/* Windows.UI.Xaml.Media.FontFamily/, ms-appx:///Assets/Fonts/Righteous-Regular.ttf#Righteous, TextBlock/FontFamily */,
								// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 18:14)
							}
							.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler1)(c3 => 
							{
								c3.Foreground = (Windows.UI.Xaml.Media.Brush)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Media.Brush), (global::Windows.UI.Xaml.Application.Current.Resources["TitleColor"] ?? throw new InvalidOperationException("The resource TitleColor cannot be found")));
								
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c3, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								Text = "Come"/* string/, Come, TextBlock/Text */,
								FontSize = 38d/* double/, 38, TextBlock/FontSize */,
								FontFamily = new Windows.UI.Xaml.Media.FontFamily("ms-appx:///Assets/Fonts/Righteous-Regular.ttf#Righteous")/* Windows.UI.Xaml.Media.FontFamily/, ms-appx:///Assets/Fonts/Righteous-Regular.ttf#Righteous, TextBlock/FontFamily */,
								Margin = new global::Windows.UI.Xaml.Thickness(15,-13,0,0)/* Windows.UI.Xaml.Thickness/, 15,-13,0,0, TextBlock/Margin */,
								// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 19:14)
							}
							.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler1)(c5 => 
							{
								c5.Foreground = (Windows.UI.Xaml.Media.Brush)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Media.Brush), (global::Windows.UI.Xaml.Application.Current.Resources["TitleColor"] ?? throw new InvalidOperationException("The resource TitleColor cannot be found")));
								
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c5, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.TextBlock
							{
								Text = ""/* string/, , TextBlock/Text */,
								// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 20:14)
							}
							.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler1)(c7 => 
							{
								c7.FontFamily = (Windows.UI.Xaml.Media.FontFamily)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Media.FontFamily), (global::Windows.UI.Xaml.Application.Current.Resources["FontAwesome"] ?? throw new InvalidOperationException("The resource FontAwesome cannot be found")));
								
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c7, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
							}
							))
							,
						}
					}
					.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler2)(c9 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c9, 0/* int/, 0, Grid/Row */);
						c9.Background = (Windows.UI.Xaml.Media.Brush)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Media.Brush), (global::Windows.UI.Xaml.Application.Current.Resources["MainColor"] ?? throw new InvalidOperationException("The resource MainColor cannot be found")));
						
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c9, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Center/* Windows.UI.Xaml.VerticalAlignment/, Center, StackPanel/VerticalAlignment */,
						// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 23:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.TextBox
							{
								Style = (Windows.UI.Xaml.Style)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Style), (global::Windows.UI.Xaml.Application.Current.Resources["TextBoxDefault"] ?? throw new InvalidOperationException("The resource TextBoxDefault cannot be found")))
								,
								PlaceholderText = "Login"/* string/, Login, TextBox/PlaceholderText */,
								// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 24:14)
							}
							.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler3)(c12 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c12, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
							}
							))
							,
							new global::Windows.UI.Xaml.Controls.PasswordBox
							{
								Style = (Windows.UI.Xaml.Style)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Style), (global::Windows.UI.Xaml.Application.Current.Resources["PasswordBoxDefault"] ?? throw new InvalidOperationException("The resource PasswordBoxDefault cannot be found")))
								,
								PlaceholderText = "Senha"/* string/, Senha, PasswordBox/PlaceholderText */,
								// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 25:14)
							}
							.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler4)(c14 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c14, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
							}
							))
							,
						}
					}
					.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler2)(c15 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c15, 1/* int/, 1, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c15, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
					}
					))
					,
					new global::Windows.UI.Xaml.Controls.StackPanel
					{
						VerticalAlignment = global::Windows.UI.Xaml.VerticalAlignment.Center/* Windows.UI.Xaml.VerticalAlignment/, Center, StackPanel/VerticalAlignment */,
						HorizontalAlignment = global::Windows.UI.Xaml.HorizontalAlignment.Center/* Windows.UI.Xaml.HorizontalAlignment/, Center, StackPanel/HorizontalAlignment */,
						Background = SolidColorBrushHelper.Blue/* Windows.UI.Xaml.Media.Brush/, Blue, StackPanel/Background */,
						// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 28:10)
						Children = 
						{
							new global::Windows.UI.Xaml.Controls.Button
							{
								Style = (Windows.UI.Xaml.Style)global::Windows.UI.Xaml.Markup.XamlBindingHelper.ConvertValue(typeof(Windows.UI.Xaml.Style), (global::Windows.UI.Xaml.Application.Current.Resources["ButtomMain"] ?? throw new InvalidOperationException("The resource ButtomMain cannot be found")))
								,
								Content = @"Entrar"/* object/, Entrar, Button/Content */,
								Width = 300d/* double/, 300, Button/Width */,
								// Source ..\..\..\..\..\..\..\UnoSample.Shared\MainPage.xaml (Line 29:14)
							}
							.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler5)(c17 => 
							{
								global::Uno.UI.FrameworkElementHelper.SetBaseUri(c17, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
							}
							))
							,
						}
					}
					.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler2)(c18 => 
					{
						global::Windows.UI.Xaml.Controls.Grid.SetRow(c18, 2/* int/, 2, Grid/Row */);
						global::Uno.UI.FrameworkElementHelper.SetBaseUri(c18, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
					}
					))
					,
				}
			}
			.MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply((MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions.XamlApplyHandler6)(c19 => 
			{
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c19, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
			}
			))
			;
			
			this
			.Apply((c20 => 
			{
				// Source C:\Users\dudup.000\Desktop\Projetos\UnoSample\UnoSample\UnoSample.Shared\MainPage.xaml (Line 1:2)
			}
			))
			.Apply((c21 => 
			{
				// Class UnoSample.MainPage
				global::Uno.UI.FrameworkElementHelper.SetBaseUri(c21, "file:///C:/Users/dudup.000/Desktop/Projetos/UnoSample/UnoSample/UnoSample.Shared/MainPage.xaml");
			}
			))
			;
			OnInitializeCompleted();
			InitializeXamlOwner();
		}
		partial void OnInitializeCompleted();
		class StaticResources
		{
		}
		private void InitializeXamlOwner()
		{
		}
	}
}
namespace UnoSample.Droid
{
	static class MainPage_93bab407d01a7ec5e2895c483e42096aXamlApplyExtensions
	{
		public delegate void XamlApplyHandler0(global::Windows.UI.Xaml.Controls.RowDefinition instance);
		public static global::Windows.UI.Xaml.Controls.RowDefinition MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply(this global::Windows.UI.Xaml.Controls.RowDefinition instance, XamlApplyHandler0 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler1(global::Windows.UI.Xaml.Controls.TextBlock instance);
		public static global::Windows.UI.Xaml.Controls.TextBlock MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply(this global::Windows.UI.Xaml.Controls.TextBlock instance, XamlApplyHandler1 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler2(global::Windows.UI.Xaml.Controls.StackPanel instance);
		public static global::Windows.UI.Xaml.Controls.StackPanel MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply(this global::Windows.UI.Xaml.Controls.StackPanel instance, XamlApplyHandler2 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler3(global::Windows.UI.Xaml.Controls.TextBox instance);
		public static global::Windows.UI.Xaml.Controls.TextBox MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply(this global::Windows.UI.Xaml.Controls.TextBox instance, XamlApplyHandler3 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler4(global::Windows.UI.Xaml.Controls.PasswordBox instance);
		public static global::Windows.UI.Xaml.Controls.PasswordBox MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply(this global::Windows.UI.Xaml.Controls.PasswordBox instance, XamlApplyHandler4 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler5(global::Windows.UI.Xaml.Controls.Button instance);
		public static global::Windows.UI.Xaml.Controls.Button MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply(this global::Windows.UI.Xaml.Controls.Button instance, XamlApplyHandler5 handler)
		{
			handler(instance);
			return instance;
		}
		public delegate void XamlApplyHandler6(global::Windows.UI.Xaml.Controls.Grid instance);
		public static global::Windows.UI.Xaml.Controls.Grid MainPage_93bab407d01a7ec5e2895c483e42096a_XamlApply(this global::Windows.UI.Xaml.Controls.Grid instance, XamlApplyHandler6 handler)
		{
			handler(instance);
			return instance;
		}
	}
}
