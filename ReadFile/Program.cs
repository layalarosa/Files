using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Considerar usar Path no por FileInfo como esta abajo
        //var path = Path.GetFullPath(@"C:\Users\layal\OneDrive\Escritorio\Newsletter.csv");

        FileInfo pathFile = new FileInfo(@"C:\Users\layal\OneDrive\Escritorio\Newsletter.csv");

        //Abrir archivo para lectura/escritura
        FileStream fs = pathFile.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

        StreamReader sr = new StreamReader(fs);

        //Utilice el método ReadToEnd para leer todo el contenido del archivo. 
        string fileContent = sr.ReadToEnd();

        var arr = fileContent.Split('\n');

        // 
        var sqlScript = "INSERT INTO table_name(column1, column2, column3, column4, column5, column6, column7,)";
        sqlScript += "\nVALUES(";

        for (int i = 0; i < arr.Length; i++)
        {
            string[] arr2 = arr[i].Split(',');
            for (int x = 0; x < arr2.Length; x++)
            {
                sqlScript += "'" + arr2[x] + "',";
            }
        }
        sqlScript += ")";

        Console.WriteLine(fileContent);

        //Cerrar el objeto StreamReader después de la operación.
        sr.Close();
        fs.Close();
    }
}
