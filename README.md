# .NET MAUI XAML Source Generation

> [!NOTE]
> There is a bug when using XAML Source Generation with .NET SDK 9.0.200. Make sure to have either a version lower or higher that you compile against. Else you will get an exception with the message "Source can only be set from XAML".

Changes made in this project:

1. In the **MauiProgram.cs** file add the following attribute above the namespace declaration: `[assembly: XamlProcessing(XamlInflator.SourceGen)]`. Technically this could be in any file, **MauiProgram.cs** seems like a logical place.
2. In each ***.xaml.cs** file, in the constructor changed `InitializeComponent();` to `InitializeComponentSourceGen();`.
3. In the .NET MAUI csproj file added `<EnablePreviewFeatures>true</EnablePreviewFeatures>` to any `<PropertyGroup>` node. Needed because the source generation feature is marked as a preview feature right now.
4. Optionally, in the csproj file add `<EmitCompilerGeneratedFiles>true</EmitCompilerGeneratedFiles>` to any `<PropertyGroup>` node. This will output the generated code under **obj/{Configuration}/{TFM}/{Platform}/generated/Microsoft.Maui.Controls.SourceGen/Microsoft.Maui.Controls.SourceGen.CodeBehindGenerator/**. The ***.xsg.cs** files are the ones you are looking for.

## Using it on an existing project

To try this out on your existing project:

1. Make sure you have a backup of your source code.
2. Download the NuGet version from the **nuget** folder in this repo and add that as a local NuGet source to your project. The provided version is close to the latest available code for the last .NET MAUI service release, based on .NET 9, but will not be identical.
3. Make sure that you update the .NET MAUI SDK reference with the version of the NuGet packages you just downloaded.
4. Follow the steps from the above section to configure your project.

## Feedback

Any and all feedback is welcome! Ideally it will all work as it did before with XAML Compilation. If you want to compare, simply change `InitializeComponentSourceGen();` back to `InitializeComponent();`, you can leave the `XamlProcessing` attribute in place, it generates the code but it isn't called if you don't do the `InitializeComponent();` call.

Keep in mind that changing `InitializeComponent();` to `InitializeComponentSourceGen();` is only temporary, just like adding a custom NuGet build, etc. so please try to keep the feedback limited to actual usage of XAML source generation and not the initial setup.
