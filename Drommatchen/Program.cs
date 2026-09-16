Spelare tomas = new Spelare("Thomas Brolin", 11, "Offensiv mittfältare",4);
Spelare krasimir = new Spelare("Krasimir Balakov", 20, "Mittfältare",0);

Match match = new Match("Sverige", "Bulgarien", "16 Juli 1994");

match.Presentera();

match.AnnounceraMålskytt(tomas);
match.AnnounceraMålskytt(krasimir);

match.ÄrMatchhjälte(tomas);
match.ÄrMatchhjälte(krasimir);