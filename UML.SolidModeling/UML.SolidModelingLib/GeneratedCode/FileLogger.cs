﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool
//     Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System.IO;

public class FileLogger:ILogger
{
    public virtual void Handle(string error)
    {
        File.WriteAllText(@"c:\Error.txt", error);
    }

}

