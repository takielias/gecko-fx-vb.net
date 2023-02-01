# gecko-fx-vb
A Great Web Automation Technology For VB.NET

One of the most Powerful Web Automation Technology is GeckoFX which supports JS. The latest version of GeckoFX is 45.0+. It is suitable for C# but not for old school.:wink: So, I'm going to make a short Tutorial for integrating GeckoFX with VB Dot NET.

I'm using vs 2017 community.

1. Make a New VB Dot NET project.

Geckofx 45.0 1.png

2. Go to Tools > NuGet Package Manager > Manage NuGet Package For Solution

Geckofx 45.0 2.jpg

3. Search For GeckoFX45 and install the latest Version. You can also install it through NuGet Package Manager Console > Install-Package Geckofx45

Geckofx 45.0 3.jpg

4. Now Go to the Property of the Project > Application > View Application Events

Remove the Existing Code and Pest the Following one.

Code:

Imports Gecko
Imports System.IO
Namespace My
    ' The following events are available for MyApplication:
    '
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active.
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Protected Overrides Function OnStartup(ByVal eventArgs As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) As Boolean
            Dim ProfileDirectory As String = My.Application.Info.DirectoryPath & "\Firefox\Profile"
            If Not Directory.Exists(ProfileDirectory) Then
                Directory.CreateDirectory(ProfileDirectory)
            End If
            Xpcom.ProfileDirectory = ProfileDirectory
            Gecko.Xpcom.Initialize("Firefox")
            Return True
        End Function
    End Class
End Namespace


5. Go to Toolbox > Right Click > Chose Items

Geckofx 45.0 6.jpg

6. Browse For Project folder > packages >Geckofx45.45.0.32 >lib > net45 > Geckofx-Winforms.dll. Select it and Press ok.

Geckofx 45.0 7.jpg
Geckofx 45.0 8.jpg
Geckofx 45.0 9.jpg
Geckofx 45.0 10.jpg

WOW, You have successfully Integrated GeckoFX 45.0. Now Drag GrckoWebBrowser From Toolbox and Drop it into your Form.
You are Done. :awyeah:

You Can Download The Project: [Mediafire](http://www.mediafire.com/file/u3ehhhgosk29ddt/TheBotWebAutomationGeckoFX45.zip)

Virus Scan
