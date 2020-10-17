CREATE TABLE IF NOT EXISTS books (
  id INT(10) AUTO_INCREMENT NOT NULL,
  Author longtext,
  LaunchDate datetime(6) NOT NULL,
  Price decimal(65,2) NOT NULL,
  Title longtext,
  PRIMARY KEY (id)
) 
ENGINE=InnoDB 
DEFAULT CHARSET=latin1
;