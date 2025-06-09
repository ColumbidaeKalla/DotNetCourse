using DotNetCourse.src.SessionThree.AppInterface;

namespace DotNetCourse.src.SessionThree.RunAppInterface;

public static class RunAppInterface {
    public static void RunShape() {
        Circle ball = new(1);
        ball.Radius = 10.0;
        ball.Name = "Football";

        ShapeManager.PrintShapeInfo(ball);
    }
}