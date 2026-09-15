Spelare tomas = new Spelare("Thomas Brolin", 11, "Offensiv mittfältare");
Spelare krasimir = new Spelare("Krasimir Balakov", 20, "Mittfältare");

Match match = new Match("Sverige", "Bulgarien", "16 Juli 1994");

match.Presentera();

match.AnnounceraMålskytt(tomas);
match.AnnounceraMålskytt(krasimir);