using System;
using System.Collections.Generic;

public class ChatBot
{
    private Dictionary<string, List<string>> keywordResponses;
    private Random random;
    private string lastTopic = "";
    private Dictionary<string, string> memory;



    public ChatBot()
    {
        random = new Random();

        memory = new Dictionary<string, string>();


        keywordResponses = new Dictionary<string, List<string>>()
        {
            {
                "password", new List<string>()
                {
                    "Use strong, unique passwords for every account.",
                    "Avoid using personal information in passwords.",
                    "Use a password manager to store credentials safely."
                }
            },

            {
                "scam", new List<string>()
                {
                    "Be cautious of messages asking for personal info.",
                    "Never share OTPs or banking details.",
                    "Check if the sender is legitimate before clicking links."
                }
            },

            {
                "privacy", new List<string>()
                {
                    "Review your social media privacy settings regularly.",
                    "Limit the personal information you share online.",
                    "Enable two-factor authentication where possible."
                }
            }
        };
    }
    public string GetKeywordResponse(string input)
    {
        input = input.ToLower();

        foreach (var keyword in keywordResponses.Keys)
        {
            if (input.Contains(keyword))
            {
                List<string> responses = keywordResponses[keyword];
                return responses[random.Next(responses.Count)];
            }
        }

        return null;
    }
    public string HandleName(string input)
    {
        input = input.ToLower();

        if (input.Contains("my name is"))
        {
            string name = input.Substring(input.IndexOf("is") + 2).Trim();

            memory["name"] = name;

            return "Nice to meet you, " + name + "! I'll remember your name.";
        }

        return null;
    }
    public string HandleInterest(string input)
    {
        input = input.ToLower();

        if (input.Contains("i am interested in"))
        {
            string interest = input.Substring(input.IndexOf("in") + 2).Trim();

            memory["interest"] = interest;

            return "Great! I'll remember that you're interested in " + interest + ".";
        }

        return null;
    }
    public string Personalise(string response)
    {
        if (memory.ContainsKey("name"))
        {
            response = response.Replace("USER", memory["name"]);
        }

        if (memory.ContainsKey("interest"))
        {
            response += "\nAs someone interested in " + memory["interest"] + ", this is especially important for you.";
        }

        return response;
    }
    public string DetectSentiment(string input)
    {
        input = input.ToLower();

        if (input.Contains("worried"))
        {
            return "worried";
        }

        if (input.Contains("frustrated"))
        {
            return "frustrated";
        }

        if (input.Contains("curious"))
        {
            return "curious";
        }

        return null;
    }
    public string HandleSentiment(string input)
    {
        string sentiment = DetectSentiment(input);

        if (sentiment == "worried")
        {
            return "It's completely understandable to feel worried. Let me help you stay safe with some cybersecurity tips.";
        }

        if (sentiment == "frustrated")
        {
            return "I understand this can be frustrating. Cybersecurity can be tricky, but I’ll simplify it for you.";
        }

        if (sentiment == "curious")
        {
            return "Great curiosity! Let’s explore this topic in more detail.";
        }

        return null;
    }
}


