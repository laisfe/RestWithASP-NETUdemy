CREATE TABLE `persons` (
	`Id` int(10) UNSIGNED NULL DEFAULT NULL,
	`FirstName` VARCHAR(50) NULL DEFAULT NULL,
	`LastNampersonse` VARCHAR(50) NULL DEFAULT NULL,
	`Address` VARCHAR(50) NULL DEFAULT NULL,
	`Gender` VARCHAR(50) NULL DEFAULT NULL
)
ENGINE=InnoDB
;

ALTER TABLE PERSONS CHANGE ID ID INT(10) AUTO_INCREMENT PRIMARY KEY;