using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace Miner {
    class Program {

        static void Main (string[] args) {
            int size = Int32.Parse (Console.ReadLine ());
            string[] commands = Console.ReadLine ().Split (' ').ToArray ();

            string[, ] cave = new string[size, size];

            int[] minerCoords = {-1, -1 };

            int mines = 0;
            int foundMines = 0;

            bool GameOver = false;

            for (int row = 0; row < size; row++) {
                string[] inptRow = Console.ReadLine ().Split (' ').ToArray ();

                for (int col = 0; col < size; col++) {
                    cave[row, col] = inptRow[col];
                    if (inptRow[col] == "s") {
                        minerCoords = new int[] { row, col };
                        continue;
                    }
                    if (inptRow[col] == "c") {
                        mines++;
                        continue;
                    }
                }
            }

            foreach (var command in commands) {
                if (command == "up") {
                    if (minerCoords[0] > 0) {
                        string placeToGo = cave[minerCoords[0] - 1, minerCoords[1]];

                        if (placeToGo == "e") {
                            System.Console.WriteLine ($"Game over! ({minerCoords[0] - 1}, {minerCoords[1]})");
                            GameOver = true;
                            cave[minerCoords[0], minerCoords[1]] = "*";
                            cave[minerCoords[0] - 1, minerCoords[1]] = "s";
                            minerCoords[0]--;
                            break;
                        }
                        if (placeToGo == "c") {
                            foundMines++;
                            cave[minerCoords[0], minerCoords[1]] = "*";
                            cave[minerCoords[0] - 1, minerCoords[1]] = "s";
                            minerCoords[0]--;
                            continue;
                        }

                        cave[minerCoords[0], minerCoords[1]] = "*";
                        cave[minerCoords[0] - 1, minerCoords[1]] = "s";
                        minerCoords[0]--;
                    }
                }

                if (command == "down") {
                    if (minerCoords[0] < cave.GetLength (0) - 1) {
                        string placeToGo = cave[minerCoords[0] + 1, minerCoords[1]];

                        if (placeToGo == "e") {
                            System.Console.WriteLine ($"Game over! ({minerCoords[0] + 1}, {minerCoords[1]})");
                            GameOver = true;
                            cave[minerCoords[0], minerCoords[1]] = "*";
                            cave[minerCoords[0] + 1, minerCoords[1]] = "s";
                            minerCoords[0]++;
                            break;
                        }
                        if (placeToGo == "c") {
                            foundMines++;
                            cave[minerCoords[0], minerCoords[1]] = "*";
                            cave[minerCoords[0] + 1, minerCoords[1]] = "s";
                            minerCoords[0]++;
                            continue;
                        }
                        cave[minerCoords[0], minerCoords[1]] = "*";
                        cave[minerCoords[0] + 1, minerCoords[1]] = "s";
                        minerCoords[0]++;
                    }
                }

                if (command == "right") {
                    if (minerCoords[1] < cave.GetLength (1) - 1) {
                        string placeToGo = cave[minerCoords[0], minerCoords[1] + 1];

                        if (placeToGo == "e") {
                            System.Console.WriteLine ($"Game over! ({minerCoords[0]}, {minerCoords[1] + 1})");
                            GameOver = true;
                            cave[minerCoords[0], minerCoords[1]] = "*";
                            cave[minerCoords[0], minerCoords[1] + 1] = "s";
                            minerCoords[1]++;
                            break;
                        }
                        if (placeToGo == "c") {
                            foundMines++;
                            cave[minerCoords[0], minerCoords[1]] = "*";
                            cave[minerCoords[0], minerCoords[1] + 1] = "s";
                            minerCoords[1]++;
                            continue;
                        }
                        cave[minerCoords[0], minerCoords[1]] = "*";
                        cave[minerCoords[0], minerCoords[1] + 1] = "s";
                        minerCoords[1]++;

                    }
                }

                if (command == "left") {
                    if (minerCoords[1] > 0) {
                        string placeToGo = cave[minerCoords[0], minerCoords[1] - 1];

                        if (placeToGo == "e") {

                            System.Console.WriteLine ($"Game over! ({minerCoords[0]}, {minerCoords[1] - 1})");
                            GameOver = true;
                            cave[minerCoords[0], minerCoords[1]] = "*";
                            cave[minerCoords[0], minerCoords[1] - 1] = "s";
                            minerCoords[1]--;
                            break;
                        }
                        if (placeToGo == "c") {
                            foundMines++;
                            cave[minerCoords[0], minerCoords[1]] = "*";
                            cave[minerCoords[0], minerCoords[1] - 1] = "s";
                            minerCoords[1]--;
                            continue;
                        }
                        cave[minerCoords[0], minerCoords[1]] = "*";
                        cave[minerCoords[0], minerCoords[1] - 1] = "s";
                        minerCoords[1]--;

                    }
                }

            }
            if (!GameOver) {
                if (foundMines == mines) {
                    System.Console.WriteLine ($"You collected all coals! ({minerCoords[0]}, {minerCoords[1]})");
                } else {
                    System.Console.WriteLine ($"{mines - foundMines} coals left. ({minerCoords[0]}, {minerCoords[1]})");
                }
            }

        }
    }
}