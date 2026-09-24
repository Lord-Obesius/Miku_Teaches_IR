using Miku_Teaches_IR.Models;

namespace Miku_Teaches_IR.Data;

public static class StudyData
{
    public static List<StudyTopic> Topics { get; } = new()
    {
        new StudyTopic
        {
            Id = "realism",
            Name = "Realism",
            Description =
                "Realism views international politics as a struggle for power and security among states.",

            Actor = "Unitary, rational states",
            Objective = "Power",
            Method = "Conquest, war, internal balancing, and external balancing",

            KeyIdeas = new()
            {
                "States are the primary actors",
                "The international system is anarchic",
                "States seek power and security",
                "States must rely on themselves",
                "Relative gains matter"
            },

            Criticisms = new()
            {
                "Can underestimate international cooperation",
                "Can understate the importance of international institutions",
                "May focus too heavily on states"
            }
        },

        new StudyTopic
        {
            Id = "liberalism",
            Name = "Liberalism",
            Description =
                "Liberalism emphasizes individuals, cooperation, institutions, and liberty.",

            Actor = "States influenced by individuals",
            Objective = "Liberty",
            Method = "Cooperation and collective security",

            KeyIdeas = new()
            {
                "Individuals matter",
                "Cooperation is possible",
                "Institutions can reduce conflict",
                "Collective security can discourage aggression",
                "Absolute gains can matter"
            },

            Criticisms = new()
            {
                "Realists argue cooperation can break down under anarchy",
                "Institutions may reflect the interests of powerful states"
            }
        },

        new StudyTopic
        {
            Id = "neorealism",
            Name = "Neorealism",
            Description =
                "Neorealism explains state behavior primarily through the structure of the international system.",

            Actor = "States",
            Objective = "Security and survival",
            Method = "Balancing within an anarchic system",

            KeyIdeas = new()
            {
                "International structure matters",
                "The system is anarchic",
                "States are concerned with survival",
                "Distribution of capabilities affects behavior",
                "Relative gains remain important"
            }
        },

        new StudyTopic
        {
            Id = "neoliberalism",
            Name = "Neoliberalism",
            Description =
                "Neoliberalism emphasizes how cooperation and institutions can exist even under anarchy.",

            Actor = "States and international institutions",
            Objective = "Cooperation and mutual gains",
            Method = "Institutions and complex interdependence",

            KeyIdeas = new()
            {
                "Cooperation can occur under anarchy",
                "Institutions can facilitate cooperation",
                "Complex interdependence creates multiple connections",
                "Military force may become less useful in some relationships",
                "Absolute gains matter"
            }
        },

        new StudyTopic
        {
            Id = "constructivism",
            Name = "Constructivism",
            Description =
                "Constructivism focuses on identities, norms, ideas, and shared understandings.",

            Actor = "States and their leaders as socially constructed actors",
            Objective = "Depends on identity and social context",
            Method = "Norms, discourse, and socialization",

            KeyIdeas = new()
            {
                "Identities shape interests",
                "Norms establish expectations for behavior",
                "Discourse can shape identities",
                "Socialization teaches actors norms",
                "International reality is partly socially constructed"
            }
        },

        new StudyTopic
        {
            Id = "radicalism",
            Name = "Radicalism",
            Description =
                "Radical approaches focus heavily on economic structures and inequality in international politics.",

            Actor = "Economic classes and structures",
            Objective = "Economic stability and parity",
            Method = "Changing unequal economic structures",

            KeyIdeas = new()
            {
                "Economic structures influence politics",
                "Power can operate through economic relationships",
                "Inequality between groups and states matters"
            }
        },

        new StudyTopic
        {
            Id = "marxism",
            Name = "Marxism",
            Description =
                "Marxism explains international relations through class conflict and economic structures.",

            Actor = "Economic classes",
            Objective = "A classless society",
            Method = "Class struggle and transformation of economic structures",

            KeyIdeas = new()
            {
                "Bourgeoisie are the ruling class",
                "Proletariat are the working class",
                "Class struggle drives historical change",
                "Capitalism creates class divisions",
                "The theoretical end goal is a classless society"
            }
        },

        new StudyTopic
        {
            Id = "dependency",
            Name = "Dependency Theory",
            Description =
                "Dependency theory focuses on unequal economic relationships between dominant and dependent states.",

            Actor = "Dominant and dependent economic systems",
            Objective = "Economic independence and parity",
            Method = "Analyzing dependency relationships",

            KeyIdeas = new()
            {
                "Dominant states benefit from unequal relationships",
                "Dependent states often provide resources or manufactured goods",
                "Corporations and other organizations can connect the systems",
                "Economic relationships can reproduce inequality"
            }
        },

        new StudyTopic
        {
            Id = "feminism",
            Name = "Feminism",
            Description =
                "Feminism is a lens or perspective used to examine how gender affects international relations.",

            Actor = "Depends on the theory being examined",
            Objective = "Depends on the feminist perspective",
            Method = "Examining gender, power, and traditionally overlooked experiences",

            KeyIdeas = new()
            {
                "Gender can affect international politics",
                "Traditional IR can overlook gendered experiences",
                "Feminism can be applied alongside other theories",
                "It is treated as a lens or perspective in this course"
            }
        }
    };

    public static List<Flashcard> Flashcards { get; } = new()
    {
        new()
        {
            Id = 1,
            TopicId = "realism",
            Question = "What is the main objective of realism?",
            Answer = "Power."
        },

        new()
        {
            Id = 2,
            TopicId = "realism",
            Question = "Who are the primary actors in realism?",
            Answer = "Unitary, rational states."
        },

        new()
        {
            Id = 3,
            TopicId = "liberalism",
            Question = "What is the main objective of liberalism?",
            Answer = "Liberty."
        },

        new()
        {
            Id = 4,
            TopicId = "liberalism",
            Question = "What does collective security mean?",
            Answer = "States cooperate so that aggression against one state can be treated as a concern for the wider group."
        },

        new()
        {
            Id = 5,
            TopicId = "neorealism",
            Question = "What does neorealism emphasize?",
            Answer = "The structure of the international system and how that structure shapes state behavior."
        },

        new()
        {
            Id = 6,
            TopicId = "neoliberalism",
            Question = "What is complex interdependence?",
            Answer = "A situation involving multiple channels of connection, no strict hierarchy of issues, and reduced usefulness of military force in some relationships."
        },

        new()
        {
            Id = 7,
            TopicId = "constructivism",
            Question = "What are norms?",
            Answer = "Shared expectations about appropriate behavior."
        },

        new()
        {
            Id = 8,
            TopicId = "constructivism",
            Question = "What is socialization?",
            Answer = "The process through which actors learn and adapt to norms."
        },

        new()
        {
            Id = 9,
            TopicId = "marxism",
            Question = "Who are the bourgeoisie?",
            Answer = "The ruling/owning class in Marxist analysis."
        },

        new()
        {
            Id = 10,
            TopicId = "marxism",
            Question = "Who are the proletariat?",
            Answer = "The working class."
        },

        new()
        {
            Id = 11,
            TopicId = "dependency",
            Question = "What does Dependency Theory focus on?",
            Answer = "Unequal economic relationships between dominant and dependent systems."
        },

        new()
        {
            Id = 12,
            TopicId = "feminism",
            Question = "How is feminism treated in this course?",
            Answer = "As a lens or perspective that can be applied to international relations."
        }
    };

    public static List<QuizQuestion> QuizQuestions { get; } = new()
    {
        new()
        {
            Id = 1,
            TopicId = "realism",
            Question = "Which objective is most associated with realism?",
            Answers = new()
            {
                "Liberty",
                "Power",
                "Classless society",
                "Identity"
            },
            CorrectAnswer = 1,
            Explanation = "Realism emphasizes power and security in an anarchic international system."
        },

        new()
        {
            Id = 2,
            TopicId = "liberalism",
            Question = "Which concept is strongly associated with liberalism?",
            Answers = new()
            {
                "Collective security",
                "Class warfare",
                "Self-help only",
                "Economic dependency"
            },
            CorrectAnswer = 0,
            Explanation = "Liberalism emphasizes cooperation and collective security."
        },

        new()
        {
            Id = 3,
            TopicId = "neorealism",
            Question = "What does neorealism emphasize?",
            Answers = new()
            {
                "Domestic psychology",
                "International system structure",
                "Gender alone",
                "Corporations alone"
            },
            CorrectAnswer = 1,
            Explanation = "Neorealism focuses on how the structure of the international system shapes state behavior."
        },

        new()
        {
            Id = 4,
            TopicId = "constructivism",
            Question = "Which three concepts are especially important to constructivism?",
            Answers = new()
            {
                "Power, war, balancing",
                "Norms, discourse, socialization",
                "Capital, labor, profit",
                "Trade, tariffs, sanctions"
            },
            CorrectAnswer = 1,
            Explanation = "Constructivism emphasizes norms, discourse, identities, and socialization."
        },

        new()
        {
            Id = 5,
            TopicId = "marxism",
            Question = "What is the conflict between bourgeoisie and proletariat called?",
            Answers = new()
            {
                "Collective security",
                "Complex interdependence",
                "Class struggle",
                "External balancing"
            },
            CorrectAnswer = 2,
            Explanation = "Marxism places class struggle at the center of its analysis."
        },

        new()
        {
            Id = 6,
            TopicId = "feminism",
            Question = "How is feminism treated in this course?",
            Answers = new()
            {
                "As a state actor",
                "As a lens/perspective",
                "As an economic system",
                "As a military strategy"
            },
            CorrectAnswer = 1,
            Explanation = "Your course treats feminism as a lens that can be applied to IR."
        }
    };

    public static List<BattleScenario> Battles { get; } = new()
    {
        new()
        {
            Id = 1,
            Scenario = "A state increases its military capabilities because it fears another state's growing power.",
            Choices = new()
            {
                "Realism",
                "Constructivism",
                "Marxism",
                "Feminism"
            },
            CorrectChoice = 0,
            Explanation = "This is an example of balancing based on concerns about power and security."
        },

        new()
        {
            Id = 2,
            Scenario = "Two states change their relationship after developing a shared identity as partners.",
            Choices = new()
            {
                "Realism",
                "Constructivism",
                "Dependency Theory",
                "Marxism"
            },
            CorrectChoice = 1,
            Explanation = "Constructivism emphasizes how identities and shared understandings can shape behavior."
        },

        new()
        {
            Id = 3,
            Scenario = "An analyst explains global inequality through the relationship between dominant and dependent economies.",
            Choices = new()
            {
                "Liberalism",
                "Neorealism",
                "Dependency Theory",
                "Constructivism"
            },
            CorrectChoice = 2,
            Explanation = "Dependency Theory focuses on unequal economic relationships between dominant and dependent systems."
        },

        new()
        {
            Id = 4,
            Scenario = "An analyst examines how traditional theories overlook gendered experiences in international politics.",
            Choices = new()
            {
                "Feminism",
                "Realism",
                "Neoliberalism",
                "Neorealism"
            },
            CorrectChoice = 0,
            Explanation = "This is the type of question a feminist IR perspective asks."
        }
    };
}