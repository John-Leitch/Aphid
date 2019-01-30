using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Components.External.ConsolePlus
{
    public class InteractiveConsole
    {
        private Dictionary<string, Action> _actionMap = new Dictionary<string, Action>();

        private Dictionary<string, Action<string[]>> _paramActionMap = new Dictionary<string, Action<string[]>>();

        private Action<string[]> _defaultAction;

        public bool IsRunning { get; private set; }

        public void RegisterAction(Action action, params string[] commands)
        {
            foreach (var c in commands)
            {
                _actionMap.Add(c, action);
            }
        }

        public void RegisterAction(Action<string[]> action, params string[] commands)
        {
            foreach (var c in commands)
            {
                _paramActionMap.Add(c, action);
            }
        }

        public void RegisterAction(Action<string[]> defaultAction) => _defaultAction = defaultAction;

        public void Run()
        {
            IsRunning = true;

            while (IsRunning)
            {
                InterpretCommand(NextCommand());
            }
        }

        private static string[] NextCommand()
        {
            DrawPrompt();
            return ArgLexer.Tokenize(Console.ReadLine());
        }

        private void InterpretCommand(string[] command)
        {
            if (command.Length == 0)
            {
                return;
            }

            Action<string[]> a2 = null;

            if (!_actionMap.TryGetValue(command[0], out var a) &&
                !_paramActionMap.TryGetValue(command[0], out a2) &&
                _defaultAction == null)
            {
                Cli.WriteErrorMessage("Unknown command ~Yellow~{0}~R~", command[0]);

                return;
            }

            if (a != null)
            {
                a();
            }
            else if (a2 != null)
            {
                a2(command);
            }
            else
            {
                _defaultAction(command);
            }
        }

        public static void DrawPrompt() => Cli.Write("~Cyan~#~R~ ");

        public static void Update(Action action)
        {
            Cli.Write("\r");
            action();
            DrawPrompt();
        }

        public void Stop() => IsRunning = false;
    }
}
