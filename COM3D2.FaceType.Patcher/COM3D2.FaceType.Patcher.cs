using System.Reflection;
using Mono.Cecil;
using Mono.Cecil.Inject;
using System.IO;

namespace COM3D2.FaceType.Patcher
{
    public static class FaceType
    {
        public static readonly string[] TargetAssemblyNames = { "Assembly-CSharp.dll" };
        private const string HOOK_NAME = "COM3D2.FaceType.Managed";

        public static void Patch(AssemblyDefinition assembly)
         
        {
            string assemblyDir = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);
            string hookDir = $"{HOOK_NAME}.dll";
            AssemblyDefinition hookAssembly = AssemblyDefinition.ReadAssembly(Path.Combine(assemblyDir, hookDir));

            TypeDefinition TBody = assembly.MainModule.GetType("TBody");
            MethodDefinition ChangeTex = TBody.GetMethod("ChangeTex");

            MethodDefinition FaceTypeHook = hookAssembly.MainModule.GetType($"{HOOK_NAME}.Hooks").GetMethod("FaceTypeHook");
            FieldDefinition goSlot = TBody.GetField("goSlot");
            
            ChangeTex.InjectWith(FaceTypeHook,  flags: InjectFlags.PassInvokingInstance | InjectFlags.PassFields | InjectFlags.PassParametersRef, typeFields: new [] {goSlot });

                       

                    


            
        }
    }
}