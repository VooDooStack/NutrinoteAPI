namespace Domain
{
    public class FirebaseUser 
    {
        public string Id { get; set; }
        public string Email{ get; init; }
        public string Username { get; init; }
        public bool EmailVerified { get; init; }
       
    }
}