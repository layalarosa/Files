using System.Collections;
using System.Collections.Generic;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // Considerar usar Path no por FileInfo como esta abajo
        //var path = Path.GetFullPath(@"C:\Users\layal\OneDrive\Escritorio\Newsletter.csv");

        // ESTE CODIGO FUNCIONA PARA INSERTAR DATOS DE UN EXCEL A SQL POR MEDIO DE ENTITYFRAMEWORK
        // ESTE CODIGO SOLO HAY QUE AÑADIR EL PATHFILE CORRECTO Y CORRER EL PROYECTO Y ESPERAR QUE CARGE LA INF

        //try
        //{
        //    FileInfo pathFile = new FileInfo(@"C:\Users\layal\OneDrive\Escritorio\Newsletter - Copy.csv");

        //    //Abrir archivo para lectura/escritura
        //    FileStream fs = pathFile.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

        //    StreamReader sr = new StreamReader(fs);

        //    //Utilice el método ReadToEnd para leer todo el contenido del archivo. 
        //    string fileContent = sr.ReadToEnd();

        //    var arr = fileContent.Split('\n');
        //    var time = DateTime.Now;
           
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        try
        //        {
        //            // Esto sirve como un tipo de index despues que hace 374 interaciones regresa a cero y vuelve a comenzar
        //            if (i == 374)
        //            {
        //                var tt = 0;
        //            }

        //            string[] arr2 = arr[i].Split(',');

        //            var toSave = new NewsletterContact();

        //            toSave.Name = arr2[2];
        //            toSave.Email = arr2[3];
        //            toSave.PreferredLocale = arr2[4];
        //            toSave.CreatedAt = time;
        //            toSave.UpdatedAt = time;

        //            _context.NewsletterContact.Add(toSave);
        //            _context.SaveChanges();
        //        }
        //        catch (Exception ex)
        //        {
        //            continue;
        //        }
        //    }
        //    //Cerrar el objeto StreamReader después de la operación.
        //    sr.Close();
        //    fs.Close();

        //}
        //catch (Exception ex)
        //{
        //    Console.WriteLine(ex.Message);
        //}
    }
}
