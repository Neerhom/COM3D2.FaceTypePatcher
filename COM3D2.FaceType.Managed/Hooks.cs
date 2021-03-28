
using System.Collections.Generic;
using System.IO;
namespace COM3D2.FaceType.Managed
{
 public static   class Hooks
    {

        public static void FaceTypeHook ( TBody self, ref string slotname, ref int subPropNo, ref int matno,
            ref string prop_name, ref string filename, ref Dictionary<string, byte[]> dicModTexData, ref MaidParts.PARTS_COLOR f_ePartsColorId )
          {
            int num = (int)TBody.hashSlotName[slotname];
            TBodySkin tBodySkin = self.goSlot[num];
            string modelname = (Path.GetFileNameWithoutExtension(tBodySkin.m_strModelFileName));
                      
            int start = modelname.IndexOf("facetype");
            if (slotname == "head" && start != -1 && filename.IndexOf("*")!=-1 )
            {
                if (!GameUty.FileSystemMod.IsExistentFile(filename.Replace("*", tBodySkin.m_strModelFileName)))
                {
                    string type = modelname.Substring(start + 8, 3);

                    filename = filename.Replace("*", "face" + type);


                }

            }
        
        }
    }
}
