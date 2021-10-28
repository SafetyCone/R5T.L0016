using System;


namespace R5T.L0016
{
    // For some reason a dummy program class is needed due to the <Project Sdk="Microsoft.NET.Sdk.Web">.
    // And <Project Sdk="Microsoft.NET.Sdk.Web"> is need to get access to the package "Microsoft.AspNetCore.App.Ref v5.0.0".
    // And the package "Microsoft.AspNetCore.App.Ref v5.0.0" is needed to get access to the Microsoft.AspNetCore.Hosting.StaticWebAssets.StaticWebAssetsLoader class.
    static class DummyProgram
    {
        public static void Main()
        {

        }
    }
}
