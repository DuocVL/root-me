using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Configuration;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Reflection;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using System.Threading;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

[assembly: AssemblyTrademark("")]
[assembly: Guid("17f66dfd-e74b-46a4-8d31-f97fd5814fe6")]
[assembly: ComVisible(false)]
[assembly: AssemblyProduct("CrackMe")]
[assembly: AssemblyCopyright("Copyright ©  2014")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyDescription("")]
[assembly: CompilationRelaxations(8)]
[assembly: AssemblyFileVersion("1.0.0.0")]
[assembly: Debuggable(DebuggableAttribute.DebuggingModes.Default | DebuggableAttribute.DebuggingModes.IgnoreSymbolStoreSequencePoints)]
[assembly: AssemblyTitle("CrackMe")]
[assembly: RuntimeCompatibility(WrapNonExceptionThrows = true)]
[assembly: TargetFramework(".NETFramework,Version=v4.5", FrameworkDisplayName = ".NET Framework 4.5")]
[assembly: AssemblyVersion("1.0.0.0")]
namespace CrackMe.My
{
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerHidden]
		[STAThread]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			((WindowsFormsApplicationBase)MyProject.Application).Run(Args);
		}

		[DebuggerStepThrough]
		public MyApplication()
			: base((AuthenticationMode)0)
		{
			((WindowsFormsApplicationBase)this).IsSingleInstance = false;
			((WindowsFormsApplicationBase)this).EnableVisualStyles = true;
			((WindowsFormsApplicationBase)this).SaveMySettingsOnExit = true;
			((WindowsFormsApplicationBase)this).ShutdownStyle = (ShutdownMode)0;
		}

		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			((WindowsFormsApplicationBase)this).MainForm = (Form)(object)MyProject.Forms.Form1;
		}
	}
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal class MyComputer : Computer
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public MyComputer()
		{
		}
	}
	[HideModuleName]
	[StandardModule]
	[GeneratedCode("MyTemplate", "11.0.0.0")]
	internal sealed class MyProject
	{
		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			public Form1 m_Form1;

			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			public Form1 Form1
			{
				get
				{
					m_Form1 = Create__Instance__(m_Form1);
					return m_Form1;
				}
				set
				{
					if (value != m_Form1)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						Dispose__Instance__(ref m_Form1);
					}
				}
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance) where T : Form, new()
			{
				if (Instance == null || ((Control)Instance).IsDisposed)
				{
					if (m_FormBeingCreated != null)
					{
						if (m_FormBeingCreated.ContainsKey(typeof(T)))
						{
							throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate"));
						}
					}
					else
					{
						m_FormBeingCreated = new Hashtable();
					}
					m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						return new T();
					}
					catch (TargetInvocationException ex) when (((Func<bool>)delegate
					{
						// Could not convert BlockContainer to single expression
						ProjectData.SetProjectError(ex);
						return ex.InnerException != null;
					}).Invoke())
					{
						string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", ex.InnerException.Message);
						throw new InvalidOperationException(resourceString, ex.InnerException);
					}
					finally
					{
						m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance) where T : Form
			{
				((Component)instance/*cast due to constrained. prefix*/).Dispose();
				instance = default(T);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public MyForms()
			{
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override bool Equals(object o)
			{
				return base.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			public override int GetHashCode()
			{
				return base.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			[DebuggerHidden]
			internal new Type GetType()
			{
				return typeof(MyWebServices);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return base.ToString();
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance) where T : new()
			{
				if (instance == null)
				{
					return new T();
				}
				return instance;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[ComVisible(false)]
		internal sealed class ThreadSafeObjectProvider<T> where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (m_ThreadStaticValue == null)
					{
						m_ThreadStaticValue = new T();
					}
					return m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}
		}

		private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

		private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

		private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

		private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

		private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static User User
		{
			[DebuggerHidden]
			get
			{
				return m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return m_MyWebServicesObjectProvider.GetInstance;
			}
		}
	}
}
namespace CrackMe
{
	[DesignerGenerated]
	public class Form1 : Form
	{
		private IContainer components;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("TextBox1")]
		private TextBox _TextBox1;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		internal virtual Label Label1
		{
			get
			{
				return _Label1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				_Label1 = value;
			}
		}

		internal virtual TextBox TextBox1
		{
			get
			{
				return _TextBox1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = TextBox1_TextChanged;
				if (_TextBox1 != null)
				{
					((Control)_TextBox1).TextChanged -= eventHandler;
				}
				_TextBox1 = value;
				if (_TextBox1 != null)
				{
					((Control)_TextBox1).TextChanged += eventHandler;
				}
			}
		}

		internal virtual Button Button1
		{
			get
			{
				return _Button1;
			}
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				EventHandler eventHandler = Button1_Click;
				if (_Button1 != null)
				{
					((Control)_Button1).Click -= eventHandler;
				}
				_Button1 = value;
				if (_Button1 != null)
				{
					((Control)_Button1).Click += eventHandler;
				}
			}
		}

		public Form1()
		{
			InitializeComponent();
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (disposing && components != null)
				{
					components.Dispose();
				}
			}
			finally
			{
				((Form)this).Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			//IL_0001: Unknown result type (might be due to invalid IL or missing references)
			//IL_000b: Expected O, but got Unknown
			//IL_000c: Unknown result type (might be due to invalid IL or missing references)
			//IL_0016: Expected O, but got Unknown
			//IL_0017: Unknown result type (might be due to invalid IL or missing references)
			//IL_0021: Expected O, but got Unknown
			Label1 = new Label();
			TextBox1 = new TextBox();
			Button1 = new Button();
			((Control)this).SuspendLayout();
			Label1.AutoSize = true;
			Label label = Label1;
			Point location = new Point(25, 27);
			((Control)label).Location = location;
			((Control)Label1).Name = "Label1";
			Label label2 = Label1;
			Size size = new Size(53, 13);
			((Control)label2).Size = size;
			((Control)Label1).TabIndex = 0;
			Label1.Text = "Password";
			TextBox textBox = TextBox1;
			location = new Point(106, 20);
			((Control)textBox).Location = location;
			((Control)TextBox1).Name = "TextBox1";
			TextBox textBox2 = TextBox1;
			size = new Size(132, 20);
			((Control)textBox2).Size = size;
			((Control)TextBox1).TabIndex = 1;
			Button button = Button1;
			location = new Point(253, 16);
			((Control)button).Location = location;
			((Control)Button1).Name = "Button1";
			Button button2 = Button1;
			size = new Size(86, 27);
			((Control)button2).Size = size;
			((Control)Button1).TabIndex = 2;
			((ButtonBase)Button1).Text = "Valider";
			((ButtonBase)Button1).UseVisualStyleBackColor = true;
			SizeF autoScaleDimensions = new SizeF(6f, 13f);
			((ContainerControl)this).AutoScaleDimensions = autoScaleDimensions;
			((ContainerControl)this).AutoScaleMode = (AutoScaleMode)1;
			size = new Size(374, 70);
			((Form)this).ClientSize = size;
			((Control)this).Controls.Add((Control)(object)Button1);
			((Control)this).Controls.Add((Control)(object)TextBox1);
			((Control)this).Controls.Add((Control)(object)Label1);
			((Form)this).FormBorderStyle = (FormBorderStyle)1;
			((Form)this).MaximizeBox = false;
			((Form)this).MinimizeBox = false;
			((Control)this).Name = "Form1";
			((Form)this).Text = "CrackMe DotNet bat86";
			((Control)this).ResumeLayout(false);
			((Control)this).PerformLayout();
		}

		private void TextBox1_TextChanged(object sender, EventArgs e)
		{
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			if (Operators.CompareString(TextBox1.Text, "DotNetOP", TextCompare: false) == 0)
			{
				Interaction.MsgBox("Bravo! Vous pouvez valider avec ce mot de passe\r\nWell done! You can validate with this password");
			}
			else
			{
				Interaction.MsgBox("Mauvais mot de passe\r\nBad password");
			}
		}
	}
}
namespace CrackMe.My.Resources
{
	[DebuggerNonUserCode]
	[HideModuleName]
	[StandardModule]
	[CompilerGenerated]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	internal sealed class Resources
	{
		private static ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(resourceMan, null))
				{
					ResourceManager resourceManager = new ResourceManager("CrackMe.Resources", typeof(Resources).Assembly);
					resourceMan = resourceManager;
				}
				return resourceMan;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return resourceCulture;
			}
			set
			{
				resourceCulture = value;
			}
		}
	}
}
namespace CrackMe.My
{
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "11.0.0.0")]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance = (MySettings)(object)SettingsBase.Synchronized((SettingsBase)(object)new MySettings());

		private static bool addedHandler;

		private static object addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());

		public static MySettings Default
		{
			get
			{
				//IL_0030: Unknown result type (might be due to invalid IL or missing references)
				//IL_003a: Expected O, but got Unknown
				if (!addedHandler)
				{
					object obj = addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					bool lockTaken = false;
					try
					{
						Monitor.Enter(obj, ref lockTaken);
						if (!addedHandler)
						{
							((WindowsFormsApplicationBase)MyProject.Application).Shutdown += new ShutdownEventHandler(AutoSaveSettings);
							addedHandler = true;
						}
					}
					finally
					{
						if (lockTaken)
						{
							Monitor.Exit(obj);
						}
					}
				}
				return defaultInstance;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[DebuggerNonUserCode]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (((WindowsFormsApplicationBase)MyProject.Application).SaveMySettingsOnExit)
			{
				((ApplicationSettingsBase)MySettingsProperty.Settings).Save();
			}
		}
	}
	[DebuggerNonUserCode]
	[StandardModule]
	[CompilerGenerated]
	[HideModuleName]
	internal sealed class MySettingsProperty
	{
		[HelpKeyword("My.Settings")]
		internal static MySettings Settings => MySettings.Default;
	}
}
