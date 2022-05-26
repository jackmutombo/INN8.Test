namespace INN8_API.Helpers;

public class BlogPost
{
  public int Id { get; set; }
  public string Title { get; set; }
  public string Description { get; set; }
  public bool Disabled { get; set; }
  public DateTime Created { get; set; }
}

public interface IBlogService
{
  void DisablePost(BlogPost post);
  BlogPost GetPost(int id);
}

public class BlogService : IBlogService
{
  public BlogPost GetPost(int id)
  {
    return new BlogPost
    {
      Id = id,
      Title = "Test",
      Description = "Test",
      Disabled = false,
      Created = DateTime.UtcNow
    };
  }

  public void DisablePost(BlogPost post)
  {
    post.Disabled = true;
  }
}