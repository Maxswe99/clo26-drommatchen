Spelare tomas = new Spelare("Thomas Brolin", 11, "Offensiv mittfältare");        // TODO: Skapa minst 2 spelare
Spelare krasimir = new Spelare("Krasimir Balakov", 20, "Mittfältare");           // Spelare spelare1 = new Spelare("Namn", nummer, "Position");
                                                                                                    // Spelare spelare2 = new Spelare(...);
Match match = new Match("Sverige", "Bulgarien", "16 Juli 1994");              // TODO: Skapa 1 match // Match match = new Match("Hemmalag", "Bortalag", "Datum");

match.Presentera();                                                                                 // TODO: Anropa match.Presentera()

match.AnnounceraMålskytt(tomas);                                                                    // TODO: Anropa match.AnnounceraMålskytt() med båda spelarna
match.AnnounceraMålskytt(krasimir);