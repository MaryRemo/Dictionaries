using System;
using System.Collections.Generic;

namespace stockDictionaries
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> stocks = new Dictionary<string, string>();
            stocks.Add("GM", "General Motors");
            stocks.Add("CAT", "Caterpillar");
            // Add a few more of your favorite stocks

            string GM = stocks["GM"];

            List<Dictionary<string, double>> purchases = new List<Dictionary<string, double>>();
            purchases.Add(new Dictionary<string, double>() { { "GM", 230.21 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 580.98 } });
            purchases.Add(new Dictionary<string, double>() { { "GM", 406.34 } });

            /*
    Define a new Dictionary to hold the aggregated purchase information.
    - The key should be a string that is the full company name.
    - The value will be the total valuation of each stock


    From the three purchases above, one of the entries
    in this new dictionary will be...
        {"General Electric", 1217.53}

    Replace the questions marks below with the correct types.
*/
            Dictionary<string, double> stockReport = new Dictionary<string, double>();
            /*
               Iterate over the purchases and record the valuation
               for each stock.
            */
            foreach (Dictionary<string, double> purchase in purchases)
            {
                foreach (KeyValuePair<string, double> stock in purchase)
                {
                    // Does the full company name key already exist in the `stockReport`?

                    // If it does, update the total valuation

                    if (stockReport.ContainsKey(stocks[stock.Key]))
                    {
                        stockReport[stocks[stock.Key]] += stock.Value;
                        Console.WriteLine(stockReport[stocks[stock.Key]]);

                        /*
                            If not, add the new key and set its value.
                            You have the value of "GE", so how can you look
                            the value of "GE" in the `stocks` dictionary
                            to get the value of "General Electric"?
                        */
                    }
                    else
                    {
                        stockReport.Add(stocks[stock.Key], stock.Value);
                    }

                    Console.WriteLine($"The position in {stock.Key} is worth {stock.Value}");
                }
            }
            // planet itteration starting here
            List<string> planetList = new List<string>() { "Mercury", "Venus", "Earth", "Mars", "Jupiter", "Saturn", "Uranus", "Neptune" };

            List<Dictionary<string, string>> probes = new List<Dictionary<string, string>>();
            probes.Add(new Dictionary<string, string>() { { "Mercury", "Mariner" } });
            probes.Add(new Dictionary<string, string>() { { "Venus", "Mariner 2" } });
            probes.Add(new Dictionary<string, string>() { { "Earth", "International Space Station" } });
            probes.Add(new Dictionary<string, string>() { { "Mars", "Curiosity" } });
            probes.Add(new Dictionary<string, string>() { { "Mars", "Another SpaceCraft" } });
            probes.Add(new Dictionary<string, string>() { { "Jupiter", "Juno" } });
            probes.Add(new Dictionary<string, string>() { { "Saturn", "Cassini" } });
            probes.Add(new Dictionary<string, string>() { { "Uranus", "Voyager 2" } });
            probes.Add(new Dictionary<string, string>() { { "Neptune", "Voyager 1" } });

            // iterate planets
            foreach (string planet in planetList)
            {
                    List<string> matchingProbes = new List<string>();

                    foreach (Dictionary<string, string> probe in probes)
                    {
                     // iterate probes
                    
                        /*
                            Does the current Dictionary contain the key of
                            the current planet? Investigate the ContainsKey()
                            method on a Dictionary.

                            If so, add the current spacecraft to `matchingProbes`.
                        */

                        if (probe.ContainsKey(planet))
                        {
                            matchingProbes.Add(probe[planet]);

                            /*
                                If not, add the new key and set its value.
                                You have the value of "GE", so how can you look
                                the value of "GE" in the `stocks` dictionary
                                to get the value of "General Electric"?
                            */
                        }
                    }
                         foreach(string matchingProbe in matchingProbes){
                            string ship = String.Join(",", matchingProbes);
                            Console.WriteLine($"{planet}: {ship}");
                        }
                    };
                }

                /*
                    Use String.Join(",", matchingProbes) as part of the
                    solution to get the output below. It's the C# way of
                    writing `array.join(",")` in JavaScript.
                */
                // Console.WriteLine($"{}: {}");
            }
        }
