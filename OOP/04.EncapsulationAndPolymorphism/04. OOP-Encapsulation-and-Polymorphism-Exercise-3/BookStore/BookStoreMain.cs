namespace BookStore
{
    using Engine;
    using UI;
    using BookStore.Interfaces;

    public class BookStoreMain
    {
        public static void Main()
        {
            IInputHandler inputHandler = new ConsoleInputHandler();
            var renderer = new ConsoleRenderer();
            BookStoreEngine engine = new BookStoreEngine(renderer,inputHandler);

            engine.Run();
        }
    }
}
