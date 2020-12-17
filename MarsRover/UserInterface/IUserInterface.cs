namespace MarsRover
{
    public interface IUserInterface
    {
        void DisplayGrid(IGrid grid, IIcons icons);
        string GetUserInput();
    }
}