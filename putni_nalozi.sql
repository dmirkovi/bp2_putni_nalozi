use [putni_nalozi]
go
CREATE TABLE "izvjestaji_kretanja_vozila" (
	"izvjestaj_kretanja_vozila_id" INT IDENTITY NOT NULL,
	"putni_izvjestaj_id" int NOT NULL,
	"stanje_brojila" int NOT NULL,
	"mjesto" varchar(30) NOT NULL,
	PRIMARY KEY("izvjestaj_kretanja_vozila_id")
);

CREATE TABLE "izvjestaj_racuni" (
	"izvjestaj_racun_id" INT IDENTITY NOT NULL,
	"putni_izvjestaj_id" int NOT NULL,
	"tip_racuna" int NOT NULL,
	"datum_vrijeme" datetime NOT NULL,
	"racun_izdao" varchar(30) NOT NULL,
	"broj_racuna" varchar(30) NOT NULL,
	"iznos" float NOT NULL,
	PRIMARY KEY("izvjestaj_racun_id")
);

CREATE TABLE "putni_izvjestaji" (
	"putni_izvjestaj_id" INT IDENTITY NOT NULL,
	"nalog_id" int NOT NULL,
	"vrijeme_polaska" datetime NOT NULL,
	"vrijeme_dolaska" datetime NOT NULL,
	"duljina_puta" float NOT NULL,
	"izvjestaj_kreirao" int NOT NULL,
	"datum_kreiranja" datetime NOT NULL,
	"dat_zad_izmjene" datetime NOT NULL,
	"zap_zad_izmjene" int NOT NULL,
	PRIMARY KEY("putni_izvjestaj_id")
);

CREATE TABLE "nalozi_mjesta" (
	"nalog_mjesta_id" INT IDENTITY NOT NULL,
	"nalog_id" int,
	"naziv_mjesta" varchar(30) NOT NULL,
	PRIMARY KEY("nalog_mjesta_id")
);

CREATE TABLE "nalozi" (
	"nalog_id" INT IDENTITY NOT NULL,
	"zaposlenik_id" int NOT NULL,
	"vozilo_id" int NOT NULL,
	"vrijeme_polaska" datetime NOT NULL,
	"vrijeme_dolaska" datetime NOT NULL,
	"svrha" text,
	"trosak_puta" float NOT NULL DEFAULT 0,
	"nalog_kreirao" int NOT NULL,
	"datum_kreiranja" datetime NOT NULL,
	"dat_zad_izmjene" datetime NOT NULL,
	"zap_zad_izmjene" int NOT NULL,
	PRIMARY KEY("nalog_id")
);

CREATE TABLE "vozila" (
	"vozilo_id" INT IDENTITY NOT NULL,
	"marka" varchar(30) NOT NULL,
	"broj_sasije" varchar(15) NOT NULL,
	"kategorija" char(1) NOT NULL,
	"nosivost" float NOT NULL,
	"broj_sjedala" int NOT NULL,
	"reg_oznaka" varchar(15) NOT NULL,
	"datum_reg" datetime NOT NULL,
	"dat_zad_izmjene" datetime NOT NULL,
	"zap_zad_izmjene" int NOT NULL,
	PRIMARY KEY("vozilo_id")
);

CREATE TABLE "zaposlenici" (
	"zaposlenik_id" INT IDENTITY NOT NULL,
	"prezime" varchar(30) NOT NULL,
	"ime" varchar(30) NOT NULL,
	"kat_a" int NOT NULL DEFAULT 0,
	"kat_b" int NOT NULL DEFAULT 0,
	"kat_c" int NOT NULL DEFAULT 0,
	"kat_d" int NOT NULL DEFAULT 0,
	"kat_e" int NOT NULL DEFAULT 0,
	"dat_zad_izmjene" datetime NOT NULL,
	"zap_zad_izmjene" int,
	PRIMARY KEY("zaposlenik_id")
);

ALTER TABLE "izvjestaji_kretanja_vozila" ADD CONSTRAINT "Ref_izvjestaji_kretanja_vozila_to_putni_izvjestaji" FOREIGN KEY ("putni_izvjestaj_id")
	REFERENCES "putni_izvjestaji"("putni_izvjestaj_id");
	

ALTER TABLE "izvjestaj_racuni" ADD CONSTRAINT "Ref_izvjestaj_racuni_to_putni_izvjestaji" FOREIGN KEY ("putni_izvjestaj_id")
	REFERENCES "putni_izvjestaji"("putni_izvjestaj_id");
	

ALTER TABLE "putni_izvjestaji" ADD CONSTRAINT "Ref_putni_izvjestaji_to_nalozi" FOREIGN KEY ("nalog_id")
	REFERENCES "nalozi"("nalog_id");
	

ALTER TABLE "putni_izvjestaji" ADD CONSTRAINT "Ref_putni_izvjestaji_to_zaposlenici" FOREIGN KEY ("zap_zad_izmjene")
	REFERENCES "zaposlenici"("zaposlenik_id");

ALTER TABLE "nalozi_mjesta" ADD CONSTRAINT "Ref_nalozi_mjesta_to_nalozi" FOREIGN KEY ("nalog_id")
	REFERENCES "nalozi"("nalog_id");
	

ALTER TABLE "nalozi" ADD CONSTRAINT "Ref_nalozi_to_zaposlenici_1" FOREIGN KEY ("zaposlenik_id")
	REFERENCES "zaposlenici"("zaposlenik_id");
	

ALTER TABLE "nalozi" ADD CONSTRAINT "Ref_nalozi_to_zaposlenici_2" FOREIGN KEY ("nalog_kreirao")
	REFERENCES "zaposlenici"("zaposlenik_id");
	

ALTER TABLE "nalozi" ADD CONSTRAINT "Ref_nalozi_to_zaposlenici_3" FOREIGN KEY ("zap_zad_izmjene")
	REFERENCES "zaposlenici"("zaposlenik_id");
	

ALTER TABLE "nalozi" ADD CONSTRAINT "Ref_nalozi_to_vozila" FOREIGN KEY ("vozilo_id")
	REFERENCES "vozila"("vozilo_id");
	

ALTER TABLE "vozila" ADD CONSTRAINT "Ref_vozila_to_zaposlenici" FOREIGN KEY ("zap_zad_izmjene")
	REFERENCES "zaposlenici"("zaposlenik_id");

ALTER TABLE "zaposlenici" ADD CONSTRAINT "Ref_zaposlenici_to_zaposlenici" FOREIGN KEY ("zap_zad_izmjene")
	REFERENCES "zaposlenici"("zaposlenik_id");
	
go