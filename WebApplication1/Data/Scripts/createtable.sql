CREATE TABLE IF NOT EXISTS `shorturldb`.`Urls` (
  `IdShortUrl` VARCHAR(8) NOT NULL,
  `FullUrl` VARCHAR(2000) NOT NULL,
  `DateCreate` DATETIME,
  `Count` INT,
  PRIMARY KEY (`IdShortUrl`));
