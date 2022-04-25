namespace StringProgressBar
{
    public static class ProgressBar
    {
        public static ProgressInfo FilledBar(double progress, double limit, int size = 40, char line = '□', char filled = '■')
        {
            if (progress > limit)
            {
                string bar = new string(filled, size + 2);
                double percentage = (progress / limit) * 100;

                return new ProgressInfo()
                {
                    ProgressString = bar,
                    Percentage = percentage
                };
            }
            else
            {
                double percentage = (double)(progress / limit);
                double rounded = Math.Round((double)size * percentage);

                int emptyProgress = (int)(size - rounded);
                string progressText = new string(filled, (int)rounded);
                string emptyProgressText = new string(line, emptyProgress);

                string bar = progressText + emptyProgressText;

                int calculated = (int)percentage * 100;

                return new ProgressInfo()
                {
                    ProgressString = bar,
                    Percentage = calculated
                };
            }
        }
    }
}