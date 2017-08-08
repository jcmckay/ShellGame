namespace ShellGame 
{
  class Shell 
  {
    public int Id { get; set; }
    public Ball Ball { get; set; }  

    public Shell(int id, Ball ball=null)
    {
      Id = id;
      Ball = ball;
    }
  }
}