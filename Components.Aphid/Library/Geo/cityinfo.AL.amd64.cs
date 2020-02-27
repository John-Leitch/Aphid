
                    namespace Components.RoslynJit
                    {
                        using System;
                        using System.Collections.Generic;

                        public static class GeneratedContainer
                        {
                            
                                public readonly struct CityInfo
                                {
                                    public readonly string Name;
                                    public readonly string State;
                                    public const string Country = "AL";
                                    public readonly double Latitude;
                                    public readonly double Longitude;

                                    public CityInfo(
                                        string name,
                                        in string state,
                                        double latitude,
                                        double longitude)
                                    {
                                        Name = name;
                                        State = state;
                                        Latitude = latitude;
                                        Longitude = longitude;
                                    }
                                }
                            
                                public static CityInfo GetClosestCity(double lat, double lng)
                                {
                                    double tmp;
                            
                                        var cur = (Math.Abs(39.72833 - lat) + Math.Abs(20.05444 - lng));
                                        var closest = 0;
                                    
                                        if ((tmp = (Math.Abs(39.87534 - lat) + Math.Abs(20.00477 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 1;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.91028 - lat) + Math.Abs(20.09222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 2;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.73278 - lat) + Math.Abs(20.19528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 3;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.78917 - lat) + Math.Abs(20.12194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 4;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.65889 - lat) + Math.Abs(20.18139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 5;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90778 - lat) + Math.Abs(20.35833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 6;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.90639 - lat) + Math.Abs(20.05833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 7;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.83611 - lat) + Math.Abs(20.16861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 8;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.95111 - lat) + Math.Abs(20.09778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 9;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.85861 - lat) + Math.Abs(20.07917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 10;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.89139 - lat) + Math.Abs(20.68139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 11;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67778 - lat) + Math.Abs(20.28694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 12;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.50222 - lat) + Math.Abs(20.36056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 13;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98083 - lat) + Math.Abs(20.28083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 14;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.05056 - lat) + Math.Abs(20.5525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 15;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87611 - lat) + Math.Abs(20.32 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 16;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.80667 - lat) + Math.Abs(20.33611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 17;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.45472 - lat) + Math.Abs(20.02556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 18;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.79694 - lat) + Math.Abs(20.77694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 19;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.63306 - lat) + Math.Abs(20.58889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 20;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61194 - lat) + Math.Abs(20.69028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 21;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.525 - lat) + Math.Abs(20.5825 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 22;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20472 - lat) + Math.Abs(20.25944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 23;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62889 - lat) + Math.Abs(20.05389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 24;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.00667 - lat) + Math.Abs(20.00889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 25;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50722 - lat) + Math.Abs(20.13472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 26;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95472 - lat) + Math.Abs(20.46222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 27;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.90833 - lat) + Math.Abs(20.34694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 28;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96333 - lat) + Math.Abs(20.63917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 29;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83417 - lat) + Math.Abs(20.11194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 30;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02472 - lat) + Math.Abs(20.07833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 31;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41111 - lat) + Math.Abs(20.53556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 32;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91333 - lat) + Math.Abs(20.55306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 33;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37722 - lat) + Math.Abs(20.21333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 34;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.69083 - lat) + Math.Abs(20.42167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 35;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.29583 - lat) + Math.Abs(20.01917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 36;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.99222 - lat) + Math.Abs(20.34417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 37;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88472 - lat) + Math.Abs(20.09944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 38;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.37528 - lat) + Math.Abs(20.15472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 39;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.57694 - lat) + Math.Abs(20.05139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 40;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.00528 - lat) + Math.Abs(20.42306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 41;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.33722 - lat) + Math.Abs(20.47 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 42;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.80111 - lat) + Math.Abs(20.40833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 43;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10722 - lat) + Math.Abs(20.36639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 44;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77611 - lat) + Math.Abs(20.24056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 45;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0975 - lat) + Math.Abs(20.14833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 46;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.53 - lat) + Math.Abs(20.42361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 47;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.04056 - lat) + Math.Abs(20.43417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 48;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.98 - lat) + Math.Abs(20.60583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 49;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05194 - lat) + Math.Abs(20.05333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 50;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.92611 - lat) + Math.Abs(20.18833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 51;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.10417 - lat) + Math.Abs(20.23833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 52;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.6275 - lat) + Math.Abs(20.27917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 53;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10528 - lat) + Math.Abs(20.22944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 54;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68361 - lat) + Math.Abs(20.01917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 55;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09028 - lat) + Math.Abs(20.57639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 56;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73278 - lat) + Math.Abs(20.03944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 57;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.08389 - lat) + Math.Abs(20.43806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 58;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09333 - lat) + Math.Abs(20.44778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 59;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.1175 - lat) + Math.Abs(20.19972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 60;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.09333 - lat) + Math.Abs(20.09056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 61;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06667 - lat) + Math.Abs(20.53528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 62;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07306 - lat) + Math.Abs(20.54889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 63;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.98611 - lat) + Math.Abs(20.5025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 64;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69417 - lat) + Math.Abs(20.94028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 65;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.48833 - lat) + Math.Abs(20.37333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 66;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94194 - lat) + Math.Abs(20.29861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 67;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.13333 - lat) + Math.Abs(20.25833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 68;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61222 - lat) + Math.Abs(20.09806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 69;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72583 - lat) + Math.Abs(20.8375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 70;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.9025 - lat) + Math.Abs(20.6525 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 71;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88111 - lat) + Math.Abs(20.18278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 72;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.785 - lat) + Math.Abs(20.70611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 73;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.19944 - lat) + Math.Abs(20.40611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 74;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20944 - lat) + Math.Abs(20.41833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 75;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.685 - lat) + Math.Abs(20.42889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 76;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.23361 - lat) + Math.Abs(20.35167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 77;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.43083 - lat) + Math.Abs(20.45556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 78;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83333 - lat) + Math.Abs(20.08333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 79;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28472 - lat) + Math.Abs(20.21194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 80;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.13333 - lat) + Math.Abs(20.16667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 81;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76139 - lat) + Math.Abs(20.69833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 82;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.16667 - lat) + Math.Abs(20.04833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 83;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92694 - lat) + Math.Abs(20.00361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 84;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42556 - lat) + Math.Abs(20.67444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 85;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56028 - lat) + Math.Abs(20.74028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 86;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50917 - lat) + Math.Abs(20.92833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 87;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65417 - lat) + Math.Abs(20.46528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 88;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60333 - lat) + Math.Abs(20.80306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 89;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.4 - lat) + Math.Abs(20.2 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 90;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58889 - lat) + Math.Abs(20.48306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 91;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70583 - lat) + Math.Abs(20.69972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 92;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68861 - lat) + Math.Abs(20.11028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 93;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.28917 - lat) + Math.Abs(20.32361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 94;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.34139 - lat) + Math.Abs(20.10861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 95;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.6275 - lat) + Math.Abs(20.08528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 96;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78667 - lat) + Math.Abs(20.90222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 97;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.17944 - lat) + Math.Abs(20.315 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 98;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70444 - lat) + Math.Abs(20.70861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 99;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.03111 - lat) + Math.Abs(20.26306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 100;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.15139 - lat) + Math.Abs(20.59722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 101;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53694 - lat) + Math.Abs(20.31333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 102;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76667 - lat) + Math.Abs(20.39139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 103;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60222 - lat) + Math.Abs(20.5125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 104;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.04667 - lat) + Math.Abs(20.1475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 105;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.20083 - lat) + Math.Abs(20.15222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 106;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14056 - lat) + Math.Abs(20.14611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 107;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78889 - lat) + Math.Abs(20.18889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 108;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.77972 - lat) + Math.Abs(20.08361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 109;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86778 - lat) + Math.Abs(20.36361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 110;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.07694 - lat) + Math.Abs(20.42194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 111;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.81194 - lat) + Math.Abs(20.05889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 112;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.19694 - lat) + Math.Abs(20.41333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 113;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.61861 - lat) + Math.Abs(20.78083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 114;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.07806 - lat) + Math.Abs(20.34194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 115;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80556 - lat) + Math.Abs(20.25111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 116;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.50694 - lat) + Math.Abs(20.08667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 117;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94611 - lat) + Math.Abs(20.00972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 118;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.31306 - lat) + Math.Abs(20.18944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 119;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.72944 - lat) + Math.Abs(20.37722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 120;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.12167 - lat) + Math.Abs(20.0275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 121;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.83889 - lat) + Math.Abs(20.36667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 122;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.1875 - lat) + Math.Abs(20.0025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 123;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15667 - lat) + Math.Abs(20.39722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 124;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60833 - lat) + Math.Abs(20.91417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 125;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86972 - lat) + Math.Abs(20.18444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 126;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.14556 - lat) + Math.Abs(20.24 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 127;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.2475 - lat) + Math.Abs(20.38028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 128;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.53444 - lat) + Math.Abs(20.45 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 129;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.07583 - lat) + Math.Abs(20.13889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 130;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.0225 - lat) + Math.Abs(20.18889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 131;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.11806 - lat) + Math.Abs(20.43583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 132;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04306 - lat) + Math.Abs(20.02972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 133;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.93778 - lat) + Math.Abs(20.01111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 134;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.67972 - lat) + Math.Abs(20.33139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 135;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.80611 - lat) + Math.Abs(20.23194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 136;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.76056 - lat) + Math.Abs(20.34111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 137;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.52194 - lat) + Math.Abs(20.28222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 138;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.06222 - lat) + Math.Abs(20.01667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 139;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.36889 - lat) + Math.Abs(20.42444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 140;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.26056 - lat) + Math.Abs(20.01694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 141;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.16694 - lat) + Math.Abs(20.35083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 142;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.33778 - lat) + Math.Abs(20.67889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 143;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1125 - lat) + Math.Abs(20.08222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 144;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.58333 - lat) + Math.Abs(20.79222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 145;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65139 - lat) + Math.Abs(20.81361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 146;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.67361 - lat) + Math.Abs(20.05833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 147;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.62917 - lat) + Math.Abs(20.25111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 148;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.50417 - lat) + Math.Abs(20.22722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 149;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4175 - lat) + Math.Abs(20.55028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 150;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.85139 - lat) + Math.Abs(20.725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 151;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.42056 - lat) + Math.Abs(20.26056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 152;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.11806 - lat) + Math.Abs(20.54083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 153;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87833 - lat) + Math.Abs(20.50472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 154;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.445 - lat) + Math.Abs(20.00472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 155;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87861 - lat) + Math.Abs(20.42194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 156;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.61028 - lat) + Math.Abs(20.00889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 157;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.49167 - lat) + Math.Abs(20.22194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 158;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.32639 - lat) + Math.Abs(20.07639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 159;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.105 - lat) + Math.Abs(20.0225 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 160;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.86139 - lat) + Math.Abs(20 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 161;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.16056 - lat) + Math.Abs(20.19194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 162;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.6275 - lat) + Math.Abs(20.99 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 163;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.99472 - lat) + Math.Abs(20.4125 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 164;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.84583 - lat) + Math.Abs(20.65722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 165;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27778 - lat) + Math.Abs(20.61833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 166;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.41667 - lat) + Math.Abs(20.13444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 167;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.91306 - lat) + Math.Abs(20.28833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 168;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.73583 - lat) + Math.Abs(20.32417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 169;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.31 - lat) + Math.Abs(20.20278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 170;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19694 - lat) + Math.Abs(20.33556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 171;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.19639 - lat) + Math.Abs(20.05972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 172;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71806 - lat) + Math.Abs(20.43806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 173;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.57111 - lat) + Math.Abs(20.15 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 174;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.27917 - lat) + Math.Abs(20.2725 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 175;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.99222 - lat) + Math.Abs(19.91389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 176;
                                        }
                                    
                                        if ((tmp = (Math.Abs(39.76889 - lat) + Math.Abs(19.99972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 177;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70917 - lat) + Math.Abs(19.64972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 178;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.70778 - lat) + Math.Abs(19.68917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 179;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38944 - lat) + Math.Abs(19.8275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 180;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.42972 - lat) + Math.Abs(19.93028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 181;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34444 - lat) + Math.Abs(19.5475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 182;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.02806 - lat) + Math.Abs(19.54778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 183;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.20972 - lat) + Math.Abs(19.69083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 184;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39083 - lat) + Math.Abs(19.655 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 185;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.4686 - lat) + Math.Abs(19.48318 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 186;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87833 - lat) + Math.Abs(19.40556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 187;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70167 - lat) + Math.Abs(19.93222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 188;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.29917 - lat) + Math.Abs(19.74417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 189;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76889 - lat) + Math.Abs(19.87778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 190;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.87528 - lat) + Math.Abs(19.79472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 191;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68278 - lat) + Math.Abs(19.89333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 192;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.76306 - lat) + Math.Abs(19.43278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 193;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.3275 - lat) + Math.Abs(19.81889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 194;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5475 - lat) + Math.Abs(19.67778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 195;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04 - lat) + Math.Abs(19.61417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 196;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18 - lat) + Math.Abs(19.5425 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 197;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38056 - lat) + Math.Abs(19.53778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 198;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75111 - lat) + Math.Abs(19.7375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 199;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64806 - lat) + Math.Abs(19.86806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 200;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06889 - lat) + Math.Abs(19.69944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 201;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.06828 - lat) + Math.Abs(19.51258 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 202;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34556 - lat) + Math.Abs(19.56722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 203;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02417 - lat) + Math.Abs(19.81611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 204;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.69083 - lat) + Math.Abs(19.65333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 205;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.81361 - lat) + Math.Abs(19.59389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 206;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18333 - lat) + Math.Abs(19.53333 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 207;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99861 - lat) + Math.Abs(19.94778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 208;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.29944 - lat) + Math.Abs(19.805 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 209;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.39639 - lat) + Math.Abs(19.72972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 210;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63528 - lat) + Math.Abs(19.755 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 211;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.45139 - lat) + Math.Abs(19.89167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 212;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53056 - lat) + Math.Abs(19.63583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 213;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67083 - lat) + Math.Abs(19.69833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 214;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.77444 - lat) + Math.Abs(19.78611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 215;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.07639 - lat) + Math.Abs(19.66528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 216;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.7675 - lat) + Math.Abs(19.87556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 217;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.32278 - lat) + Math.Abs(19.51028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 218;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96778 - lat) + Math.Abs(19.82111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 219;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.04444 - lat) + Math.Abs(19.97056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 220;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7375 - lat) + Math.Abs(19.70222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 221;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88639 - lat) + Math.Abs(19.51139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 222;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.05306 - lat) + Math.Abs(19.83722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 223;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.08972 - lat) + Math.Abs(19.895 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 224;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.04444 - lat) + Math.Abs(19.89972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 225;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.21333 - lat) + Math.Abs(19.94472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 226;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.42722 - lat) + Math.Abs(19.67278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 227;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78028 - lat) + Math.Abs(19.84417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 228;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.69917 - lat) + Math.Abs(19.57444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 229;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.2175 - lat) + Math.Abs(19.69611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 230;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.25306 - lat) + Math.Abs(19.85306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 231;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05 - lat) + Math.Abs(19.79917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 232;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.77889 - lat) + Math.Abs(19.92306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 233;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.04611 - lat) + Math.Abs(19.75111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 234;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64278 - lat) + Math.Abs(19.65083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 235;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.68333 - lat) + Math.Abs(19.61944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 236;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.35389 - lat) + Math.Abs(19.80667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 237;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05167 - lat) + Math.Abs(19.96083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 238;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.05472 - lat) + Math.Abs(19.8375 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 239;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74389 - lat) + Math.Abs(19.93528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 240;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.32528 - lat) + Math.Abs(19.47139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 241;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.625 - lat) + Math.Abs(19.46694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 242;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.44417 - lat) + Math.Abs(19.74833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 243;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.24444 - lat) + Math.Abs(19.75806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 244;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.64444 - lat) + Math.Abs(19.7925 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 245;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.26389 - lat) + Math.Abs(19.65583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 246;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.68389 - lat) + Math.Abs(19.71556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 247;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.35167 - lat) + Math.Abs(19.98028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 248;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.75361 - lat) + Math.Abs(19.57944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 249;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.42861 - lat) + Math.Abs(19.59306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 250;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.5775 - lat) + Math.Abs(19.69222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 251;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.37917 - lat) + Math.Abs(19.6075 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 252;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.1275 - lat) + Math.Abs(19.57389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 253;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.94194 - lat) + Math.Abs(19.705 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 254;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.44278 - lat) + Math.Abs(19.95444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 255;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83444 - lat) + Math.Abs(19.55222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 256;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.78361 - lat) + Math.Abs(19.64361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 257;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.67611 - lat) + Math.Abs(19.48972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 258;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.29472 - lat) + Math.Abs(19.93167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 259;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.11444 - lat) + Math.Abs(19.60972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 260;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63556 - lat) + Math.Abs(19.71306 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 261;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.47333 - lat) + Math.Abs(19.76639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 262;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.78389 - lat) + Math.Abs(19.78667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 263;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.7175 - lat) + Math.Abs(19.74556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 264;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72667 - lat) + Math.Abs(19.68667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 265;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.80028 - lat) + Math.Abs(19.91667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 266;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.03972 - lat) + Math.Abs(19.52528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 267;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.10056 - lat) + Math.Abs(19.5275 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 268;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.87194 - lat) + Math.Abs(19.68083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 269;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.50917 - lat) + Math.Abs(19.79278 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 270;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21556 - lat) + Math.Abs(19.97139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 271;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.43861 - lat) + Math.Abs(19.84444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 272;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.83083 - lat) + Math.Abs(19.90056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 273;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.38944 - lat) + Math.Abs(19.60222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 274;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.21361 - lat) + Math.Abs(19.43639 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 275;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.58167 - lat) + Math.Abs(19.98556 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 276;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82417 - lat) + Math.Abs(19.60389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 277;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.78667 - lat) + Math.Abs(19.67611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 278;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18556 - lat) + Math.Abs(19.55694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 279;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.40306 - lat) + Math.Abs(19.51806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 280;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.3525 - lat) + Math.Abs(19.48917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 281;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.34972 - lat) + Math.Abs(19.71028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 282;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.06306 - lat) + Math.Abs(19.71611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 283;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92194 - lat) + Math.Abs(19.71778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 284;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38167 - lat) + Math.Abs(19.76028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 285;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.84889 - lat) + Math.Abs(19.68694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 286;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.41806 - lat) + Math.Abs(19.82139 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 287;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59 - lat) + Math.Abs(19.77833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 288;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.91417 - lat) + Math.Abs(19.88944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 289;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.89333 - lat) + Math.Abs(19.89861 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 290;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.54528 - lat) + Math.Abs(19.6 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 291;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.97167 - lat) + Math.Abs(19.78972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 292;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.36194 - lat) + Math.Abs(19.44417 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 293;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.10167 - lat) + Math.Abs(19.74472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 294;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.18028 - lat) + Math.Abs(19.60694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 295;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.56194 - lat) + Math.Abs(19.73583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 296;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.48278 - lat) + Math.Abs(19.69972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 297;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.95306 - lat) + Math.Abs(19.63778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 298;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.53611 - lat) + Math.Abs(19.99083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 299;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.045 - lat) + Math.Abs(19.57472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 300;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.15917 - lat) + Math.Abs(19.51889 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 301;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.55194 - lat) + Math.Abs(19.77833 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 302;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92944 - lat) + Math.Abs(19.9475 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 303;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.88806 - lat) + Math.Abs(19.58583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 304;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.15194 - lat) + Math.Abs(19.96361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 305;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.95306 - lat) + Math.Abs(19.58083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 306;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.09056 - lat) + Math.Abs(19.62472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 307;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.96778 - lat) + Math.Abs(19.68528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 308;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.02556 - lat) + Math.Abs(19.72389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 309;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.33306 - lat) + Math.Abs(19.57806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 310;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.65028 - lat) + Math.Abs(19.62 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 311;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47833 - lat) + Math.Abs(19.71778 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 312;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5 - lat) + Math.Abs(19.81667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 313;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.65583 - lat) + Math.Abs(19.5025 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 314;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.86722 - lat) + Math.Abs(19.78528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 315;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.71667 - lat) + Math.Abs(19.56667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 316;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72389 - lat) + Math.Abs(19.55611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 317;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.30556 - lat) + Math.Abs(19.86694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 318;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.32355 - lat) + Math.Abs(19.45469 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 319;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60056 - lat) + Math.Abs(19.70083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 320;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99667 - lat) + Math.Abs(19.52944 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 321;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.74556 - lat) + Math.Abs(19.49389 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 322;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.01 - lat) + Math.Abs(19.62472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 323;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.39361 - lat) + Math.Abs(19.91583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 324;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.99167 - lat) + Math.Abs(19.41056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 325;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.91556 - lat) + Math.Abs(19.60444 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 326;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.73028 - lat) + Math.Abs(19.79056 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 327;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.50944 - lat) + Math.Abs(19.84583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 328;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.03167 - lat) + Math.Abs(19.97583 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 329;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.60333 - lat) + Math.Abs(19.62611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 330;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.11944 - lat) + Math.Abs(19.89972 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 331;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.81806 - lat) + Math.Abs(19.64083 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 332;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.47417 - lat) + Math.Abs(19.65167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 333;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.26778 - lat) + Math.Abs(19.66917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 334;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24528 - lat) + Math.Abs(19.90111 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 335;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.38 - lat) + Math.Abs(19.6875 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 336;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.01528 - lat) + Math.Abs(19.48167 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 337;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.70583 - lat) + Math.Abs(19.95222 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 338;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.975 - lat) + Math.Abs(19.88194 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 339;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.63194 - lat) + Math.Abs(19.92917 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 340;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.82492 - lat) + Math.Abs(19.84074 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 341;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59889 - lat) + Math.Abs(19.73472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 342;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.99528 - lat) + Math.Abs(19.76528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 343;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.21389 - lat) + Math.Abs(19.79694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 344;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.53639 - lat) + Math.Abs(19.59611 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 345;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.59444 - lat) + Math.Abs(19.80667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 346;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.8575 - lat) + Math.Abs(19.75528 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 347;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.24583 - lat) + Math.Abs(19.53472 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 348;
                                        }
                                    
                                        if ((tmp = (Math.Abs(41.81917 - lat) + Math.Abs(19.64028 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 349;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.16222 - lat) + Math.Abs(19.49667 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 350;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.92056 - lat) + Math.Abs(19.84694 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 351;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.72667 - lat) + Math.Abs(19.75722 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 352;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.5475 - lat) + Math.Abs(19.84806 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 353;
                                        }
                                    
                                        if ((tmp = (Math.Abs(40.45694 - lat) + Math.Abs(19.64361 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 354;
                                        }
                                    
                                        if ((tmp = (Math.Abs(42.35734 - lat) + Math.Abs(20.07679 - lng))) < cur)
                                        {
                                            cur = tmp;
                                            closest = 355;
                                        }
                                    
                                    switch (closest)
                                    {
                            case 0: return new CityInfo("Xarrë", "51", 39.72833, 20.05444);
case 1: return new CityInfo("Sarandë", "51", 39.87534, 20.00477);
case 2: return new CityInfo("Mesopotam", "51", 39.91028, 20.09222);
case 3: return new CityInfo("Markat", "51", 39.73278, 20.19528);
case 4: return new CityInfo("Livadhja", "51", 39.78917, 20.12194);
case 5: return new CityInfo("Konispol", "51", 39.65889, 20.18139);
case 6: return new CityInfo("Kakavijë", "45", 39.90778, 20.35833);
case 7: return new CityInfo("Finiq", "51", 39.90639, 20.05833);
case 8: return new CityInfo("Dhivër", "51", 39.83611, 20.16861);
case 9: return new CityInfo("Delvinë", "51", 39.95111, 20.09778);
case 10: return new CityInfo("Aliko", "51", 39.85861, 20.07917);
case 11: return new CityInfo("Buçimas", "46", 40.89139, 20.68139);
case 12: return new CityInfo("Zhepë", "40", 40.67778, 20.28694);
case 13: return new CityInfo("Zerqan", "41", 41.50222, 20.36056);
case 14: return new CityInfo("Zavalinë", "43", 40.98083, 20.28083);
case 15: return new CityInfo("Zapod", "47", 42.05056, 20.5525);
case 16: return new CityInfo("Zall-Reç", "41", 41.87611, 20.32);
case 17: return new CityInfo("Zall-Dardhë", "41", 41.80667, 20.33611);
case 18: return new CityInfo("Xibër-Murrizë", "41", 41.45472, 20.02556);
case 19: return new CityInfo("Vreshtas", "46", 40.79694, 20.77694);
case 20: return new CityInfo("Voskopojë", "46", 40.63306, 20.58889);
case 21: return new CityInfo("Voskop", "46", 40.61194, 20.69028);
case 22: return new CityInfo("Vithkuq", "46", 40.525, 20.5825);
case 23: return new CityInfo("Vithkuq", "45", 40.20472, 20.25944);
case 24: return new CityInfo("Vërtop", "40", 40.62889, 20.05389);
case 25: return new CityInfo("Vergo", "51", 40.00667, 20.00889);
case 26: return new CityInfo("Vendresha e Vogël", "40", 40.50722, 20.13472);
case 27: return new CityInfo("Velçan", "46", 40.95472, 20.46222);
case 28: return new CityInfo("Ujmisht", "47", 41.90833, 20.34694);
case 29: return new CityInfo("Udënisht", "46", 40.96333, 20.63917);
case 30: return new CityInfo("Tunjë", "43", 40.83417, 20.11194);
case 31: return new CityInfo("Tregan", "43", 41.02472, 20.07833);
case 32: return new CityInfo("Trebisht-Muçinë", "41", 41.41111, 20.53556);
case 33: return new CityInfo("Trebinjë", "46", 40.91333, 20.55306);
case 34: return new CityInfo("Topojan", "45", 40.37722, 20.21333);
case 35: return new CityInfo("Tomin", "41", 41.69083, 20.42167);
case 36: return new CityInfo("Tepelenë", "45", 40.29583, 20.01917);
case 37: return new CityInfo("Surroj", "47", 41.99222, 20.34417);
case 38: return new CityInfo("Sult", "43", 40.88472, 20.09944);
case 39: return new CityInfo("Sukë", "45", 40.37528, 20.15472);
case 40: return new CityInfo("Suç", "41", 41.57694, 20.05139);
case 41: return new CityInfo("Stravaj", "43", 41.00528, 20.42306);
case 42: return new CityInfo("Steblevë", "43", 41.33722, 20.47);
case 43: return new CityInfo("Sllovë", "41", 41.80111, 20.40833);
case 44: return new CityInfo("Skore", "45", 40.10722, 20.36639);
case 45: return new CityInfo("Skënderbegas", "43", 40.77611, 20.24056);
case 46: return new CityInfo("Shushicë", "43", 41.0975, 20.14833);
case 47: return new CityInfo("Shupenzë", "41", 41.53, 20.42361);
case 48: return new CityInfo("Shtiqën", "47", 42.04056, 20.43417);
case 49: return new CityInfo("Shishtavec", "47", 41.98, 20.60583);
case 50: return new CityInfo("Shirgjan", "43", 41.05194, 20.05333);
case 51: return new CityInfo("Shëngjin", "48", 41.92611, 20.18833);
case 52: return new CityInfo("Shënmëri", "47", 42.10417, 20.23833);
case 53: return new CityInfo("Selishtë", "41", 41.6275, 20.27917);
case 54: return new CityInfo("Saraqinishtë", "45", 40.10528, 20.22944);
case 55: return new CityInfo("Rukaj", "41", 41.68361, 20.01917);
case 56: return new CityInfo("Rajcë", "43", 41.09028, 20.57639);
case 57: return new CityInfo("Roshnik", "40", 40.73278, 20.03944);
case 58: return new CityInfo("Qukës-Skënderbe", "43", 41.08389, 20.43806);
case 59: return new CityInfo("Qukës-Shkumbin", "43", 41.09333, 20.44778);
case 60: return new CityInfo("Qestorat", "45", 40.1175, 20.19972);
case 61: return new CityInfo("Qafëmal", "49", 42.09333, 20.09056);
case 62: return new CityInfo("Përrenjas-Fshat", "43", 41.06667, 20.53528);
case 63: return new CityInfo("Përrenjas", "43", 41.07306, 20.54889);
case 64: return new CityInfo("Proptisht", "46", 40.98611, 20.5025);
case 65: return new CityInfo("Progër", "46", 40.69417, 20.94028);
case 66: return new CityInfo("Potom", "40", 40.48833, 20.37333);
case 67: return new CityInfo("Poroçan", "43", 40.94194, 20.29861);
case 68: return new CityInfo("Polis-Gostimë", "43", 41.13333, 20.25833);
case 69: return new CityInfo("Poliçan", "40", 40.61222, 20.09806);
case 70: return new CityInfo("Pojan", "46", 40.72583, 20.8375);
case 71: return new CityInfo("Pogradec", "46", 40.9025, 20.6525);
case 72: return new CityInfo("Pishaj", "43", 40.88111, 20.18278);
case 73: return new CityInfo("Pirg", "46", 40.785, 20.70611);
case 74: return new CityInfo("Gjinkar", "45", 40.19944, 20.40611);
case 75: return new CityInfo("Petran", "45", 40.20944, 20.41833);
case 76: return new CityInfo("Peshkopi", "41", 41.685, 20.42889);
case 77: return new CityInfo("Përmet", "45", 40.23361, 20.35167);
case 78: return new CityInfo("Ostreni i Math", "41", 41.43083, 20.45556);
case 79: return new CityInfo("Orosh", "48", 41.83333, 20.08333);
case 80: return new CityInfo("Orenjë", "43", 41.28472, 20.21194);
case 81: return new CityInfo("Odrie", "45", 40.13333, 20.16667);
case 82: return new CityInfo("Novoselë", "46", 40.76139, 20.69833);
case 83: return new CityInfo("Picar", "45", 40.16667, 20.04833);
case 84: return new CityInfo("Mollas", "43", 40.92694, 20.00361);
case 85: return new CityInfo("Mollas", "46", 40.42556, 20.67444);
case 86: return new CityInfo("Mollaj", "46", 40.56028, 20.74028);
case 87: return new CityInfo("Miras", "46", 40.50917, 20.92833);
case 88: return new CityInfo("Melan", "41", 41.65417, 20.46528);
case 89: return new CityInfo("Mborje", "46", 40.60333, 20.80306);
case 90: return new CityInfo("Martanesh", "41", 41.4, 20.2);
case 91: return new CityInfo("Maqellarë", "41", 41.58889, 20.48306);
case 92: return new CityInfo("Maliq", "46", 40.70583, 20.69972);
case 93: return new CityInfo("Macukull", "41", 41.68861, 20.11028);
case 94: return new CityInfo("Lunik", "43", 41.28917, 20.32361);
case 95: return new CityInfo("Llugaj", "47", 42.34139, 20.10861);
case 96: return new CityInfo("Lis", "41", 41.6275, 20.08528);
case 97: return new CityInfo("Liqenas", "46", 40.78667, 20.90222);
case 98: return new CityInfo("Librazhd", "43", 41.17944, 20.315);
case 99: return new CityInfo("Libonik", "46", 40.70444, 20.70861);
case 100: return new CityInfo("Libohovë", "45", 40.03111, 20.26306);
case 101: return new CityInfo("Leskovik", "46", 40.15139, 20.59722);
case 102: return new CityInfo("Leshnjë", "40", 40.53694, 20.31333);
case 103: return new CityInfo("Lenias", "43", 40.76667, 20.39139);
case 104: return new CityInfo("Lekas", "46", 40.60222, 20.5125);
case 105: return new CityInfo("Lazarat", "45", 40.04667, 20.1475);
case 106: return new CityInfo("Labinot-Mal", "43", 41.20083, 20.15222);
case 107: return new CityInfo("Labinot-Fushë", "43", 41.14056, 20.14611);
case 108: return new CityInfo("Kushovë", "43", 40.78889, 20.18889);
case 109: return new CityInfo("Kurbnesh", "48", 41.77972, 20.08361);
case 110: return new CityInfo("Kukur", "43", 40.86778, 20.36361);
case 111: return new CityInfo("Kukës", "47", 42.07694, 20.42194);
case 112: return new CityInfo("Kthella e Epërme", "48", 41.81194, 20.05889);
case 113: return new CityInfo("Krumë", "47", 42.19694, 20.41333);
case 114: return new CityInfo("Korçë", "46", 40.61861, 20.78083);
case 115: return new CityInfo("Kolsh", "47", 42.07806, 20.34194);
case 116: return new CityInfo("Kodovjat", "43", 40.80556, 20.25111);
case 117: return new CityInfo("Klos", "41", 41.50694, 20.08667);
case 118: return new CityInfo("Klos", "43", 40.94611, 20.00972);
case 119: return new CityInfo("Këlcyrë", "45", 40.31306, 20.18944);
case 120: return new CityInfo("Kastriot", "41", 41.72944, 20.37722);
case 121: return new CityInfo("Kardhiq", "45", 40.12167, 20.0275);
case 122: return new CityInfo("Kalis", "47", 41.83889, 20.36667);
case 123: return new CityInfo("Iballë", "49", 42.1875, 20.0025);
case 124: return new CityInfo("Hotolisht", "43", 41.15667, 20.39722);
case 125: return new CityInfo("Hoçisht", "46", 40.60833, 20.91417);
case 126: return new CityInfo("Gramsh", "43", 40.86972, 20.18444);
case 127: return new CityInfo("Gostimë", "43", 41.14556, 20.24);
case 128: return new CityInfo("Golaj", "47", 42.2475, 20.38028);
case 129: return new CityInfo("Gjorica e Sipërme", "41", 41.53444, 20.45);
case 130: return new CityInfo("Gjirokastër", "45", 40.07583, 20.13889);
case 131: return new CityInfo("Gjinar", "43", 41.0225, 20.18889);
case 132: return new CityInfo("Gjinaj", "47", 42.11806, 20.43583);
case 133: return new CityInfo("Gjergjan", "43", 41.04306, 20.02972);
case 134: return new CityInfo("Gjegjan", "49", 41.93778, 20.01111);
case 135: return new CityInfo("Fushë-Muhurr", "41", 41.67972, 20.33139);
case 136: return new CityInfo("Fushë-Lurë", "41", 41.80611, 20.23194);
case 137: return new CityInfo("Fushë-Çidhnë", "41", 41.76056, 20.34111);
case 138: return new CityInfo("Fushë-Bulqizë", "41", 41.52194, 20.28222);
case 139: return new CityInfo("Fushë-Arrëz", "49", 42.06222, 20.01667);
case 140: return new CityInfo("Frashër", "45", 40.36889, 20.42444);
case 141: return new CityInfo("Fierzë", "49", 42.26056, 20.01694);
case 142: return new CityInfo("Fajzë", "47", 42.16694, 20.35083);
case 143: return new CityInfo("Ersekë", "46", 40.33778, 20.67889);
case 144: return new CityInfo("Elbasan", "43", 41.1125, 20.08222);
case 145: return new CityInfo("Drenovë", "46", 40.58333, 20.79222);
case 146: return new CityInfo("Dishnicë", "46", 40.65139, 20.81361);
case 147: return new CityInfo("Derjan", "41", 41.67361, 20.05833);
case 148: return new CityInfo("Gjerbës", "40", 40.62917, 20.25111);
case 149: return new CityInfo("Çorovodë", "40", 40.50417, 20.22722);
case 150: return new CityInfo("Çlirim", "46", 40.4175, 20.55028);
case 151: return new CityInfo("Cerava", "46", 40.85139, 20.725);
case 152: return new CityInfo("Çepan", "40", 40.42056, 20.26056);
case 153: return new CityInfo("Çarshovë", "45", 40.11806, 20.54083);
case 154: return new CityInfo("Kokaj", "47", 41.87833, 20.50472);
case 155: return new CityInfo("Buz", "45", 40.445, 20.00472);
case 156: return new CityInfo("Bushtricë", "47", 41.87861, 20.42194);
case 157: return new CityInfo("Burrel", "41", 41.61028, 20.00889);
case 158: return new CityInfo("Bulqizë", "41", 41.49167, 20.22194);
case 159: return new CityInfo("Bujan", "47", 42.32639, 20.07639);
case 160: return new CityInfo("Bradashesh", "43", 41.105, 20.0225);
case 161: return new CityInfo("Blinisht", "48", 41.86139, 20);
case 162: return new CityInfo("Blerim", "49", 42.16056, 20.19194);
case 163: return new CityInfo("Bilisht", "46", 40.6275, 20.99);
case 164: return new CityInfo("Bicaj", "47", 41.99472, 20.4125);
case 165: return new CityInfo("Dardhas", "46", 40.84583, 20.65722);
case 166: return new CityInfo("Barmash", "46", 40.27778, 20.61833);
case 167: return new CityInfo("Ballaban", "45", 40.41667, 20.13444);
case 168: return new CityInfo("Arrën", "47", 41.91306, 20.28833);
case 169: return new CityInfo("Arras", "41", 41.73583, 20.32417);
case 170: return new CityInfo("Bytyç", "47", 42.31, 20.20278);
case 171: return new CityInfo("Librazhd-Qendër", "43", 41.19694, 20.33556);
case 172: return new CityInfo("Funarë", "43", 41.19639, 20.05972);
case 173: return new CityInfo("Moglicë", "46", 40.71806, 20.43806);
case 174: return new CityInfo("Bogovë", "40", 40.57111, 20.15);
case 175: return new CityInfo("Piskovë", "45", 40.27917, 20.2725);
case 176: return new CityInfo("Lukovë", "51", 39.99222, 19.91389);
case 177: return new CityInfo("Ksamil", "51", 39.76889, 19.99972);
case 178: return new CityInfo("Zharrëz", "44", 40.70917, 19.64972);
case 179: return new CityInfo("Zejmen", "48", 41.70778, 19.68917);
case 180: return new CityInfo("Zall-Herr", "50", 41.38944, 19.8275);
case 181: return new CityInfo("Zall-Bastar", "50", 41.42972, 19.93028);
case 182: return new CityInfo("Xhafzotaj", "42", 41.34444, 19.5475);
case 183: return new CityInfo("Vukatanë", "49", 42.02806, 19.54778);
case 184: return new CityInfo("Vranisht", "51", 40.20972, 19.69083);
case 185: return new CityInfo("Vorë", "50", 41.39083, 19.655);
case 186: return new CityInfo("Vlorë", "51", 40.4686, 19.48318);
case 187: return new CityInfo("Velipojë", "49", 41.87833, 19.40556);
case 188: return new CityInfo("Velabisht", "40", 40.70167, 19.93222);
case 189: return new CityInfo("Vaqarr", "50", 41.29917, 19.74417);
case 190: return new CityInfo("Ura Vajgurore", "40", 40.76889, 19.87778);
case 191: return new CityInfo("Ungrej", "48", 41.87528, 19.79472);
case 192: return new CityInfo("Ulëz", "41", 41.68278, 19.89333);
case 193: return new CityInfo("Topojë", "44", 40.76306, 19.43278);
case 194: return new CityInfo("Tirana", "50", 41.3275, 19.81889);
case 195: return new CityInfo("Thumanë", "42", 41.5475, 19.67778);
case 196: return new CityInfo("Tërbuf", "44", 41.04, 19.61417);
case 197: return new CityInfo("Synej", "50", 41.18, 19.5425);
case 198: return new CityInfo("Sukth", "42", 41.38056, 19.53778);
case 199: return new CityInfo("Strum", "44", 40.75111, 19.7375);
case 200: return new CityInfo("Sinjë", "40", 40.64806, 19.86806);
case 201: return new CityInfo("Sinaballaj", "50", 41.06889, 19.69944);
case 202: return new CityInfo("Shkodër", "49", 42.06828, 19.51258);
case 203: return new CityInfo("Shijak", "42", 41.34556, 19.56722);
case 204: return new CityInfo("Shezë", "43", 41.02417, 19.81611);
case 205: return new CityInfo("Shënkoll", "48", 41.69083, 19.65333);
case 206: return new CityInfo("Shëngjin", "48", 41.81361, 19.59389);
case 207: return new CityInfo("Shëngjergj", "50", 41.18333, 19.53333);
case 208: return new CityInfo("Shalës", "43", 40.99861, 19.94778);
case 209: return new CityInfo("Nicaj-Shalë", "49", 42.29944, 19.805);
case 210: return new CityInfo("Sevaster", "51", 40.39639, 19.72972);
case 211: return new CityInfo("Selitë", "48", 41.63528, 19.755);
case 212: return new CityInfo("Valbonë", "47", 42.45139, 19.89167);
case 213: return new CityInfo("Selenicë", "51", 40.53056, 19.63583);
case 214: return new CityInfo("Ruzhdie", "44", 40.67083, 19.69833);
case 215: return new CityInfo("Rubik", "48", 41.77444, 19.78611);
case 216: return new CityInfo("Rrogozhinë", "50", 41.07639, 19.66528);
case 217: return new CityInfo("Rrëshen", "48", 41.7675, 19.87556);
case 218: return new CityInfo("Rrashbull", "42", 41.32278, 19.51028);
case 219: return new CityInfo("Rrasa e Sipërme", "43", 40.96778, 19.82111);
case 220: return new CityInfo("Rrapë", "49", 42.04444, 19.97056);
case 221: return new CityInfo("Roskovec", "44", 40.7375, 19.70222);
case 222: return new CityInfo("Remas", "44", 40.88639, 19.51139);
case 223: return new CityInfo("Qerret", "49", 42.05306, 19.83722);
case 224: return new CityInfo("Qelëz", "49", 42.08972, 19.895);
case 225: return new CityInfo("Pukë", "49", 42.04444, 19.89972);
case 226: return new CityInfo("Progonat", "45", 40.21333, 19.94472);
case 227: return new CityInfo("Prezë", "50", 41.42722, 19.67278);
case 228: return new CityInfo("Poshnje", "40", 40.78028, 19.84417);
case 229: return new CityInfo("Portëz", "44", 40.69917, 19.57444);
case 230: return new CityInfo("Peza e Madhe", "50", 41.2175, 19.69611);
case 231: return new CityInfo("Petrelë", "50", 41.25306, 19.85306);
case 232: return new CityInfo("Përparim", "43", 41.05, 19.79917);
case 233: return new CityInfo("Perondi", "40", 40.77889, 19.92306);
case 234: return new CityInfo("Peqin", "43", 41.04611, 19.75111);
case 235: return new CityInfo("Patos Fshat", "44", 40.64278, 19.65083);
case 236: return new CityInfo("Patos", "44", 40.68333, 19.61944);
case 237: return new CityInfo("Paskuqan", "50", 41.35389, 19.80667);
case 238: return new CityInfo("Papër", "43", 41.05167, 19.96083);
case 239: return new CityInfo("Pajovë", "43", 41.05472, 19.8375);
case 240: return new CityInfo("Otllak", "40", 40.74389, 19.93528);
case 241: return new CityInfo("Orikum", "51", 40.32528, 19.47139);
case 242: return new CityInfo("Novoselë", "51", 40.625, 19.46694);
case 243: return new CityInfo("Nikël", "42", 41.44417, 19.74833);
case 244: return new CityInfo("Nicaj-Shosh", "49", 42.24444, 19.75806);
case 245: return new CityInfo("Ngraçan", "44", 40.64444, 19.7925);
case 246: return new CityInfo("Ndroq", "50", 41.26389, 19.65583);
case 247: return new CityInfo("Milot", "48", 41.68389, 19.71556);
case 248: return new CityInfo("Memaliaj", "45", 40.35167, 19.98028);
case 249: return new CityInfo("Mbrostar-Urë", "44", 40.75361, 19.57944);
case 250: return new CityInfo("Manzë", "42", 41.42861, 19.59306);
case 251: return new CityInfo("Mamurras", "48", 41.5775, 19.69222);
case 252: return new CityInfo("Maminas", "42", 41.37917, 19.6075);
case 253: return new CityInfo("Luzi i Vogël", "50", 41.1275, 19.57389);
case 254: return new CityInfo("Lushnjë", "44", 40.94194, 19.705);
case 255: return new CityInfo("Luftinjë", "45", 40.44278, 19.95444);
case 256: return new CityInfo("Libofshë", "44", 40.83444, 19.55222);
case 257: return new CityInfo("Lezhë", "48", 41.78361, 19.64361);
case 258: return new CityInfo("Levan", "44", 40.67611, 19.48972);
case 259: return new CityInfo("Lekbibaj", "47", 42.29472, 19.93167);
case 260: return new CityInfo("Lekaj", "50", 41.11444, 19.60972);
case 261: return new CityInfo("Laç", "48", 41.63556, 19.71306);
case 262: return new CityInfo("Kutë", "44", 40.47333, 19.76639);
case 263: return new CityInfo("Kutalli", "40", 40.78389, 19.78667);
case 264: return new CityInfo("Kurjan", "44", 40.7175, 19.74556);
case 265: return new CityInfo("Kuman", "44", 40.72667, 19.68667);
case 266: return new CityInfo("Kuçovë", "40", 40.80028, 19.91667);
case 267: return new CityInfo("Kuç", "49", 42.03972, 19.52528);
case 268: return new CityInfo("Kryevidh", "50", 41.10056, 19.5275);
case 269: return new CityInfo("Krutja e Poshtme", "44", 40.87194, 19.68083);
case 270: return new CityInfo("Krujë", "42", 41.50917, 19.79278);
case 271: return new CityInfo("Krrabë", "50", 41.21556, 19.97139);
case 272: return new CityInfo("Krahës", "45", 40.43861, 19.84444);
case 273: return new CityInfo("Kozarë", "40", 40.83083, 19.90056);
case 274: return new CityInfo("Kotë", "51", 40.38944, 19.60222);
case 275: return new CityInfo("Koplik", "49", 42.21361, 19.43639);
case 276: return new CityInfo("Kombësi", "41", 41.58167, 19.98556);
case 277: return new CityInfo("Kolonjë", "44", 40.82417, 19.60389);
case 278: return new CityInfo("Kolç", "48", 41.78667, 19.67611);
case 279: return new CityInfo("Kavajë", "50", 41.18556, 19.55694);
case 280: return new CityInfo("Katundi i Ri", "42", 41.40306, 19.51806);
case 281: return new CityInfo("Kastrat", "49", 42.3525, 19.48917);
case 282: return new CityInfo("Kashar", "50", 41.34972, 19.71028);
case 283: return new CityInfo("Karinë", "43", 41.06306, 19.71611);
case 284: return new CityInfo("Karbunara e Vogël", "44", 40.92194, 19.71778);
case 285: return new CityInfo("Kamëz", "50", 41.38167, 19.76028);
case 286: return new CityInfo("Kallmeti i Madh", "48", 41.84889, 19.68694);
case 287: return new CityInfo("Kallmet", "50", 41.41806, 19.82139);
case 288: return new CityInfo("Kalenjë", "44", 40.59, 19.77833);
case 289: return new CityInfo("Kajan", "43", 40.91417, 19.88944);
case 290: return new CityInfo("Kaçinar", "48", 41.89333, 19.89861);
case 291: return new CityInfo("Ishëm", "42", 41.54528, 19.6);
case 292: return new CityInfo("Hysgjokaj", "44", 40.97167, 19.78972);
case 293: return new CityInfo("Hot", "49", 42.36194, 19.44417);
case 294: return new CityInfo("Himarë", "51", 40.10167, 19.74472);
case 295: return new CityInfo("Helmas", "50", 41.18028, 19.60694);
case 296: return new CityInfo("Hekal", "44", 40.56194, 19.73583);
case 297: return new CityInfo("Hasan", "42", 41.48278, 19.69972);
case 298: return new CityInfo("Hajmel", "49", 41.95306, 19.63778);
case 299: return new CityInfo("Gurra e Vogël", "41", 41.53611, 19.99083);
case 300: return new CityInfo("Guri i Zi", "49", 42.045, 19.57472);
case 301: return new CityInfo("Gruemirë", "49", 42.15917, 19.51889);
case 302: return new CityInfo("Greshicë", "44", 40.55194, 19.77833);
case 303: return new CityInfo("Grekan", "43", 40.92944, 19.9475);
case 304: return new CityInfo("Gradishtë", "44", 40.88806, 19.58583);
case 305: return new CityInfo("Gracen", "43", 41.15194, 19.96361);
case 306: return new CityInfo("Grabjan", "44", 40.95306, 19.58083);
case 307: return new CityInfo("Gosë e Madhe", "50", 41.09056, 19.62472);
case 308: return new CityInfo("Golem", "44", 40.96778, 19.68528);
case 309: return new CityInfo("Gjoçaj", "43", 41.02556, 19.72389);
case 310: return new CityInfo("Gjepalaj", "42", 41.33306, 19.57806);
case 311: return new CityInfo("Fushëkuqe", "48", 41.65028, 19.62);
case 312: return new CityInfo("Fushë-Krujë", "42", 41.47833, 19.71778);
case 313: return new CityInfo("Fratar", "44", 40.5, 19.81667);
case 314: return new CityInfo("Frakulla e Madhe", "44", 40.65583, 19.5025);
case 315: return new CityInfo("Fier-Shegan", "44", 40.86722, 19.78528);
case 316: return new CityInfo("Fier-Çifçi", "44", 40.71667, 19.56667);
case 317: return new CityInfo("Fier", "44", 40.72389, 19.55611);
case 318: return new CityInfo("Farka e Madhe", "50", 41.30556, 19.86694);
case 319: return new CityInfo("Durrës", "42", 41.32355, 19.45469);
case 320: return new CityInfo("Drenovë", "44", 40.60056, 19.70083);
case 321: return new CityInfo("Divjakë", "44", 40.99667, 19.52944);
case 322: return new CityInfo("Dërmënas", "44", 40.74556, 19.49389);
case 323: return new CityInfo("Vau i Dejës", "49", 42.01, 19.62472);
case 324: return new CityInfo("Dajt", "50", 41.39361, 19.91583);
case 325: return new CityInfo("Dajç", "49", 41.99167, 19.41056);
case 326: return new CityInfo("Dajç", "48", 41.91556, 19.60444);
case 327: return new CityInfo("Cukalat", "40", 40.73028, 19.79056);
case 328: return new CityInfo("Cudhi Zall", "42", 41.50944, 19.84583);
case 329: return new CityInfo("Cërrik", "43", 41.03167, 19.97583);
case 330: return new CityInfo("Cakran", "44", 40.60333, 19.62611);
case 331: return new CityInfo("Bushat", "49", 42.11944, 19.89972);
case 332: return new CityInfo("Bubullimë", "44", 40.81806, 19.64083);
case 333: return new CityInfo("Bubq", "42", 41.47417, 19.65167);
case 334: return new CityInfo("Brataj", "51", 40.26778, 19.66917);
case 335: return new CityInfo("Bërzhitë", "50", 41.24528, 19.90111);
case 336: return new CityInfo("Bërxull", "50", 41.38, 19.6875);
case 337: return new CityInfo("Bërdica e Madhe", "49", 42.01528, 19.48167);
case 338: return new CityInfo("Berat", "40", 40.70583, 19.95222);
case 339: return new CityInfo("Belsh", "43", 40.975, 19.88194);
case 340: return new CityInfo("Baz", "41", 41.63194, 19.92917);
case 341: return new CityInfo("Banaj", "40", 40.82492, 19.84074);
case 342: return new CityInfo("Ballsh", "44", 40.59889, 19.73472);
case 343: return new CityInfo("Ballagat", "44", 40.99528, 19.76528);
case 344: return new CityInfo("Baldushk", "50", 41.21389, 19.79694);
case 345: return new CityInfo("Armen", "51", 40.53639, 19.59611);
case 346: return new CityInfo("Aranitas", "44", 40.59444, 19.80667);
case 347: return new CityInfo("Allkaj", "44", 40.8575, 19.75528);
case 348: return new CityInfo("Golem", "50", 41.24583, 19.53472);
case 349: return new CityInfo("Balldreni i Ri", "48", 41.81917, 19.64028);
case 350: return new CityInfo("Grudë-Fushë", "49", 42.16222, 19.49667);
case 351: return new CityInfo("Fierzë", "43", 40.92056, 19.84694);
case 352: return new CityInfo("Dushk", "44", 40.72667, 19.75722);
case 353: return new CityInfo("Selitë", "44", 40.5475, 19.84806);
case 354: return new CityInfo("Vllahinë", "51", 40.45694, 19.64361);
default: return new CityInfo("Bajram Curri", "47", 42.35734, 20.07679);

                                    }                                        
                                }
                            
                        }
                    }
                