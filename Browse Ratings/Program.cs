using Browse_Ratings;

class Solution
{
    public static void Main()
    {
        MaxStack stack = new();
        stack.Pusher(5);
        stack.Pusher(0);
        stack.Pusher(2);
        stack.Pusher(4);
        stack.Pusher(6);
        stack.Pusher(3);
        stack.Pusher(10);

        Console.WriteLine($"Maximum rating: {stack.MaxRating()}");

        stack.Poppers();
        Console.WriteLine("\nAfter clicking back button\n");

        Console.WriteLine($"Maximum Rating: {stack.MaxRating()}");
    }
}