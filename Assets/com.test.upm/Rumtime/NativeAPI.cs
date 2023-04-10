using System;
using System.Runtime.InteropServices;

public class NativeAPI
{
#if (UNITY_ANDROID || UNITY_IPHONE || UNITY_TVOS || UNITY_WEBGL || UNITY_SWITCH) && !UNITY_EDITOR
    const string IMPORT = "__Internal";
#else
    const string IMPORT = "TestPlugin";
#endif

    [DllImport(IMPORT)]
    public static extern int CountUp();
}
