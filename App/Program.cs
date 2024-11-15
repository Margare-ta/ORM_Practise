// See https://aka.ms/new-console-template for more information
using Songs;


using (var db = new DatabaseContext())
{
    //var songs = db.Songs.Where(song => song.Rating > 1);
    // LINQ : Language integrated quer
    var songs = from s in db.Songs
                where s.Rating > 1
                select s;

    foreach (var s in songs)
    {
        Console.WriteLine("Songs's title: " + s.Title);
    }



    var song = new Song() { Title = "Ganxta Zoli Tehet Mindenről", Author = "Krúbi", LenthInMP = 303, Price = 11100, Rating = 9 };
    db.Songs.Add(song);
    db.SaveChanges();

    Console.ReadLine();


}