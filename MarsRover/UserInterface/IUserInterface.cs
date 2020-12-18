namespace MarsRover
{
    public interface IUserInterface
    {
        void Print(string input);
        void DisplayGrid(IGrid grid, IIcons icons);
        string GetUserInput();
    }
}