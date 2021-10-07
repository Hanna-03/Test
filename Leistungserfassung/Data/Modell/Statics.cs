namespace DataLib.Modell
{
    public static class Statics
    {
        public const string ConnectionString = "mongodb://localhost:27017/TestDB";
        public const string DatabaseName = "TestDB";
        public const string TraineeCollection = "TraineeCollection";
        public const string QuestionCollection = "QuestionCollection";
        public const string TestCollection = "TestCollection";
        public const string ResultCollection = "ResultCollection";

        public static string GetCollectionString(string _objname)
        {
            switch (_objname)
            {
                case "Trainee":
                    return TraineeCollection;
                case "Question":
                    return QuestionCollection;
                case "Test":
                    return TestCollection;
                case "Result":
                    return ResultCollection;
                default:
                    return string.Empty;
            }
        }
    }
}
