using ChallengeApp8;


var user1 = new getUser("Robert", "Pedro", 44);
var user2 = new getUser("Martyna", "Wiermoń", 34);
var user3 = new getUser("Kamil", "Dobrzerski", 35);

user1.AddScore(7);
user1.AddScore(14);
user1.AddScore(3);
user1.AddScore(11);
user1.AddScore(2);

user2.AddScore(1);
user2.AddScore(9);
user2.AddScore(2);
user2.AddScore(5);
user2.AddScore(3);

user3.AddScore(8);
user3.AddScore(1);
user3.AddScore(6);
user3.AddScore(11);
user3.AddScore(12);

List<getUser> users = new List<getUser>()
{
    user1, user2, user3
};

List<getUser> users2 = new List<getUser>();

int maxValue = -1;
getUser maxScoredEmployee = null;

foreach (var user in users)
{
    if (user.Result > maxValue)
    {
        maxScoredEmployee = user;
        maxValue = user.Result;
        users2.Clear();
    }
    if (user.Result == maxValue)
    {
        users2.Add(user);
    }
}
int counter = users2.Count;

if (counter > 1)
{
    Console.WriteLine("We have winners:");
    foreach (var use2 in users2)
    {
        Console.WriteLine($"{user2.Name} {user2.Surname} age: {user2.Age} ");

    }
    Console.WriteLine("With higest score:" + maxValue);

}
else
    Console.WriteLine($" The higest scored user is {maxScoredEmployee.Name} {maxScoredEmployee.Surname} Age: {maxScoredEmployee.Age} with score: {maxScoredEmployee.Result}");