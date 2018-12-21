namespace Exercism.Analyzers.CSharp.Analysis.Solutions
{
    public readonly struct Solution
    {
        public readonly string Id;
        public readonly Exercise Exercise;

        public Solution(string id, Exercise exercise) => (Id, Exercise) = (id, exercise);
    }
}