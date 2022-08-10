using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Logging")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("MAHARAN")]
[assembly: AssemblyProduct("Logging")]
[assembly: AssemblyCopyright("Copyright © MAHARAN 2018")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("df49a3a6-9c53-43ce-b980-5b311bbd8b12")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.3.0.0")]

// 1.1.0.0  TraceLogger moved here from Graph
// 1.2.0.0  a checking added to supress setting Main.Log more than once in order to prevent further complications when multiple applications running in an integrated environment (such as IntegUi) are trying to set this static property individually.
// 1.2.1.0  make NullLog public
// 1.2.2.0  add new LogStarter.Start overload
// 1.3.0.0  add LogStarter.Stop & Main.Clear