using System;
using System.IO;
using UnityEngine;

public class Draw : MonoBehaviour
{
    string[][] fortunes; // 二维数组，用于存储多组运势

    void Start()
    {
        string filePath = "fortunes.txt";

        try
        {
            // 读取文件内容到字符串数组
            string[] lines = File.ReadAllLines(filePath);

            // 将字符串数组转换为二维数组
            fortunes = new string[lines.Length][];
            for (int i = 0; i < lines.Length; i++)
            {
                fortunes[i] = lines[i].Split(',');
            }

            // 输出文件内容
            Debug.Log("从文件中读取的运势：");
            foreach (string[] fortuneGroup in fortunes)
            {
                foreach (string fortune in fortuneGroup)
                {
                    Debug.Log(fortune.Trim()); // 使用 Trim() 方法去除空格
                }
            }
        }
        catch (IOException e)
        {
            Debug.LogError("文件读取错误：" + e.Message);
        }

        // 随机选择一组运势
        System.Random random = new();
        int groupIndex = random.Next(fortunes.Length);
        string[] selectedFortunes = fortunes[groupIndex];
        
        // 随机选择一条运势
        int index = random.Next(selectedFortunes.Length);
        
        Debug.Log("祝您好運：" + selectedFortunes[index].Trim());
    }
}
