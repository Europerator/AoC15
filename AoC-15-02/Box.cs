namespace AoC_15_02
{
    public class Box
    {
        private int length;
        private int width;
        private int height;
        public Box(string dimensions)
        {
            string[] splitDimensions = dimensions.Split('x');
            try
            {
                this.length = int.Parse(splitDimensions[0]);
                this.width = int.Parse(splitDimensions[1]);
                this.height = int.Parse(splitDimensions[2]);
            }
            catch (FormatException f)
            {
                throw new NotImplementedException(f.ToString());
            }
        }
        public Box(int len, int wid, int hei)
        {
            this.length = len;
            this.width = wid;
            this.height = hei;
        }
        public int getLength()
        {
            return this.length;
        }
        public int getWidth()
        {
            return this.width;
        }
        public int getHeight()
        {
            return this.height;
        }
        public int[] listSideAreas()
        {
            return new int[] { this.length*this.width, this.length*this.height, this.width*this.height };
        }
        public int requiredArea()
        {
            int area = 0;
            int[] sides = this.listSideAreas();
            foreach (int side in sides)
            {
                area += side * 2;
            }
            return area+sides.Min();
        }
    }
}