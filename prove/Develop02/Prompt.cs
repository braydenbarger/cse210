class Prompt
{
    private static List<string> prompts = new List<string>
    {
        "What was the best part of your day?",
        "What did you learn today?",
        "Describe a challenge you faced today.",
        "What made you happy today?",
        "What is one goal for tomorrow?"
    };

    public static string GetPrompt(int id)
    {
        return prompts[id - 1];
    }
}