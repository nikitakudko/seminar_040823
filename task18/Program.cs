string CoordinateRange(int num);
{
    if(num == 1) return "x > 0, y > 0 ";
    if(num == 2) return "x < 0, y > 0 ";
    if(num == 3) return "x < 0, y < 0 ";
    if(num == 4) return "x > 0, y < 0 ";
    return null;
}