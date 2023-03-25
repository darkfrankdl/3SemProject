using DataAccessLayer;
using DataAccessLayer.Implementations;
using DataAccessLayer.Models;
using System.Globalization;

// arrange
CommentDAO commentDAO = new CommentDAO();
CommentDAO commentDAO2 = new CommentDAO();
CommentDAO commentDAO3 = new CommentDAO();
PersonDAO personDAO = new PersonDAO();
UsertypeDAO usertypeDAO = new UsertypeDAO();
PostDAO postDAO = new PostDAO();
TopicDAO topicDAO = new TopicDAO();

// adding comments to db

Usertype usertype = new Usertype();
usertype.Type = "Moderator";

Person person = new Person();
person.Username = "1";
person.Usertype = usertype.Type;
person.Password = "123";
person.Points = 0;

Person person2 = new Person();
person2.Username = "2";
person2.Usertype = usertype.Type;
person2.Password = "1234";
person2.Points = 0;

Person person3 = new Person();
person3.Username = "3";
person3.Usertype = usertype.Type;
person3.Password = "1234";
person3.Points = 0;



// topic made by the first person
Topic topic = new Topic();
topic.CategoryName = "MyTEST";
topic.Username = person.Username;
topic.NewCategoryname = "NewCategoryName";





// post made by the first person
Post post = new Post();
post.TimeOfPost = new DateTime(2010, 10, 10);
post.Username = person.Username;
post.Text = "post text";
post.TopicCategoryName = topic.CategoryName;
post.Title = "my title";
post.Points = 1;


Comment comment1 = new Comment();
comment1.DateTime = new DateTime(2010, 10, 11);
comment1.Username = person.Username;
comment1.Text = "myText";
comment1.PostDateTime = post.TimeOfPost;
comment1.PostUsername = post.Username;

Comment comment2 = new Comment();
comment2.DateTime = new DateTime(2010, 10, 11);
comment2.Username = person2.Username;
comment2.Text = "myText2";
comment2.PostDateTime = post.TimeOfPost;
comment2.PostUsername = post.Username;

Comment comment3 = new Comment();
comment3.DateTime = new DateTime(2010, 10, 11);
comment3.Username = person3.Username;
comment3.Text = "myText3";
comment3.PostDateTime = post.TimeOfPost;
comment3.PostUsername = post.Username;



try
{
    commentDAO.DeleteComment(comment1);
    commentDAO2.DeleteComment(comment2);
    commentDAO3.DeleteComment(comment3);
    postDAO.Delete(post);
    topicDAO.Delete(topic);
    personDAO.Delete(person);
    personDAO.Delete(person2);
    personDAO.Delete(person3);

    //usertypeDAO.Insert(usertype);
    personDAO.InsertPerson(person);
    personDAO.InsertPerson(person2);
    personDAO.InsertPerson(person3);
    topicDAO.Insert(topic);
    postDAO.Insert(post);

    Console.WriteLine("Post points before " + postDAO.GetPost(post.Username, post.TimeOfPost.ToString()).Points);
    Console.WriteLine("Person 1 : points " + personDAO.GetPerson(person2.Username).Points);
    Console.WriteLine("Person 2 : points " + personDAO.GetPerson(person2.Username).Points);
    Console.WriteLine("Person 3 : points " + personDAO.GetPerson(person3.Username).Points);

    Console.WriteLine("\n" + "Running");

    Task t1 = Task.Run(() => Method1());
    Task t2 = Task.Run(() => Method2());
    Task t3 = Task.Run(() => Method3());

    void Method1()
    {
        commentDAO.AddComment(comment1);
    }

    void Method2()
    {
        commentDAO2.AddComment(comment2);
    }

    void Method3()
    {
        commentDAO3.AddComment(comment3);
    }

    Task.WaitAll(t1, t2, t3);
    Console.WriteLine("Post points after " + postDAO.GetPost(post.Username, post.TimeOfPost.ToString()).Points);
    Console.WriteLine("Person 1 : points " + personDAO.GetPerson(person.Username).Points);
    Console.WriteLine("Person 2 : points " + personDAO.GetPerson(person2.Username).Points);
    Console.WriteLine("Person 3 : points " + personDAO.GetPerson(person3.Username).Points);
    Console.WriteLine("Number of comments : " + commentDAO.GetAll(post.TimeOfPost,post.Username).ToList().Count);
}
catch (Exception e)
{
    Console.WriteLine("catch block");
}
finally
{
    commentDAO.DeleteComment(comment1);
    commentDAO2.DeleteComment(comment2);
    commentDAO3.DeleteComment(comment3);
    postDAO.Delete(post);
    topicDAO.Delete(topic);
    personDAO.Delete(person);
    personDAO.Delete(person2);
    personDAO.Delete(person3);


}

Console.ReadLine();



