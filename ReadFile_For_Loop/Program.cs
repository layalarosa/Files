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

        // 2 Forma
        for (int i = 0; i < arr.Length; i++)
        {
            string[] arr2 = arr[i].Split(',');

            //var toSave = new NewsletterContact();

            //toSave.Name = arr2[2];
            //toSave.Email = arr2[3];
            //toSave.PreferredLocale = arr2[4];
            //toSave.CreatedAt = time;
            //toSave.UpdatedAt = time;

            //_context.NewsletterContact.Add(toSave);
            //_context.SaveChanges();

        }

        // NO BORRAR POR EL MOMENTO 
        // for (int i = 0; i < arr.Length; i++)
        // {
        // string[] arr2 = arr[i].Split(',');

        //    var toSave = new NewsletterContact();

        //toSave.Name = arr2[2];
        //toSave.Email = arr2[3];
        //toSave.PreferredLocale = arr2[4];
        //toSave.CreatedAt = time;
        //toSave.UpdatedAt = time;

        //    _context.NewsletterContact.Add(toSave);
        //    _context.SaveChanges();

        //}

        Console.WriteLine(fileContent);

        //Cerrar el objeto StreamReader después de la operación.
        sr.Close();
        fs.Close();

        //try
        //{
        //    FileInfo pathFile = new FileInfo(@"C:\Users\layal\OneDrive\Escritorio\Newsletter.csv");

        //    //Abrir archivo para lectura/escritura
        //    FileStream fs = pathFile.Open(FileMode.OpenOrCreate, FileAccess.Read, FileShare.Read);

        //    StreamReader sr = new StreamReader(fs);

        //    //Utilice el método ReadToEnd para leer todo el contenido del archivo. 
        //    string fileContent = sr.ReadToEnd();

        //    var arr = fileContent.Split('\n');
        //    var time = DateTime.Now;

        //    // 2 Forma
        //    for (int i = 0; i < arr.Length; i++)
        //    {
        //        string[] arr2 = arr[i].Split(',');

        //        var toSave = new NewsletterContact();

        //        toSave.Name = arr2[2];
        //        toSave.Email = arr2[3];
        //        toSave.PreferredLocale = arr2[4];
        //        toSave.CreatedAt = time;
        //        toSave.UpdatedAt = time;

        //        _context.NewsletterContact.Add(toSave);
        //        _context.SaveChanges();

        //    }

        //    //Console.WriteLine(fileContent);

        //    //Cerrar el objeto StreamReader después de la operación.
        //    sr.Close();
        //    fs.Close();

        //} 
        //catch (Exception ex)
        //{
        //  Console.WriteLine(ex.Message);
        //}
    }
}
