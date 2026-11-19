using UnityEditor;
using UnityEngine;
using IFix; // Namespace của IFix

public class AutoBuildPatch
{
    // Hàm này sẽ được Github Actions gọi qua tham số -executeMethod
    public static void GeneratePatch()
    {
        Debug.Log("=== Bắt đầu Generate IFix Patch ===");
        try
        {
            // Gọi hàm Inject và Generate mặc định của IFix
            IFixEditor.InjectAssembly();
            IFixEditor.GeneratePatch();
            Debug.Log("=== Tạo Patch Thành công! ===");
        }
        catch (System.Exception e)
        {
            Debug.LogError("Lỗi Generate Patch: " + e.Message);
            EditorApplication.Exit(1); // Báo lỗi cho Github Actions biết
        }
    }
}
