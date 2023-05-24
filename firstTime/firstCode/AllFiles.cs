using System;
using System.Collections.Generic;
using System.Text;

namespace Project {

    // abstract word means it is only for methods that other
    // classes take
    // abstract class Allfiles 
    // {
    //     public string? Name {get; set;}
    //     public int Size {get; set;}
    //     public DateTime whenCreatedFile {get; set;}

    //     public static int CountOfFiles = 0;

    //     // private string? PrivateStr {get; set;} // does not have access
    //     protected string? PrivateStr {get; set;} 
    //     // does have access  
    // }

    // when using interface there is no need for abstract or public
    interface IFile {
        string? Name {get; set;}

        int Size {get; set;}
        DateTime whenCreatedFile {get; set;}
        

        // private string? PrivateStr {get; set;} 
        // does not have access
            // protected string? PrivateStr {get; set;} 
        //  does have access  
    }
}