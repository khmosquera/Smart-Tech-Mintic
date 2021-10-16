namespace PeliculaIISemanaIV.Shared.Entity
{
    public class MovieActor
    {
        public int ActorId {get;set;}
        public int MovieId {get;set;}
        public Actor Actor {get;set;}
        public Movie Movie {get;set;}
       // Campos adionales en la relación debíl de muchos a muchos
       public int OrderCredits{get;set;}
       public string Character {get;set;}
    }
    
 }