/* 01.03. Основни команди за работа с таблици */

/* Problem 12. База от данни Movies */
CREATE DATABASE IF NOT EXISTS `movies`;

/* directors */
CREATE TABLE IF NOT EXISTS `movies`.`directors` 
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `director_name` TEXT NULL, 
    `notes` TEXT NULL,
    CONSTRAINT `pk_directors` PRIMARY KEY (`id`)
);

INSERT INTO `movies`.`directors` (`director_name`) VALUES ("Steven King");
INSERT INTO `movies`.`directors` (`director_name`) VALUES ("Steven Spelberg");
INSERT INTO `movies`.`directors` (`director_name`) VALUES ("Steven Segal");
INSERT INTO `movies`.`directors` (`director_name`) VALUES ("Steven Hawkins");

/* genres */
CREATE TABLE IF NOT EXISTS `movies`.`genres` 
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `genre_name` TEXT NULL, 
    `notes` TEXT NULL,
    CONSTRAINT `pk_genres` PRIMARY KEY (`id`)
);

INSERT INTO `movies`.`genres` (`genre_name`) VALUES ("comedy");
INSERT INTO `movies`.`genres` (`genre_name`) VALUES ("tragedy");
INSERT INTO `movies`.`genres` (`genre_name`) VALUES ("drama");
INSERT INTO `movies`.`genres` (`genre_name`) VALUES ("horror");
INSERT INTO `movies`.`genres` (`genre_name`) VALUES ("science - fiction");

/* categories */
CREATE TABLE IF NOT EXISTS `movies`.`categories`
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `category_name` TEXT NULL, 
    `notes` TEXT NULL,
    CONSTRAINT `pk_categories` PRIMARY KEY (`id`)
);

INSERT INTO `movies`.`categories` (`category_name`) VALUES ("16+");
INSERT INTO `movies`.`categories` (`category_name`) VALUES ("18+");
INSERT INTO `movies`.`categories` (`category_name`) VALUES ("21+");

/* movies */
CREATE TABLE IF NOT EXISTS `movies`.`movies`
(
	`id` INT AUTO_INCREMENT NOT NULL UNIQUE,
    `title` TEXT NULL, 
    `director_id` INT NOT NULL, 
    `copyright_year` DATE NULL, 
    `length` TIME NULL, 
	`genre_id` INT NOT NULL, 
    `category_id` INT NOT NULL, 
    `rating` INT(1) DEFAULT 0, 
    `notes` TEXT NULL,
    CONSTRAINT `pk_movies` PRIMARY KEY (`id`),
    CONSTRAINT `fk_director` FOREIGN KEY (`director_id`) REFERENCES `movies`.`directors`(`id`),
    CONSTRAINT `fk_genre` FOREIGN KEY (`genre_id`) REFERENCES `movies`.`genres`(`id`),
    CONSTRAINT `fk_category` FOREIGN KEY (`category_id`) REFERENCES `movies`.`categories`(`id`)
);

INSERT INTO `movies`.`movies` (`title`, `director_id`, `copyright_year`, `length`, `genre_id`, `category_id`, `rating`)
VALUES ('Game of nerves', '4','1982-01-01','01:20','1','3','5');
 INSERT INTO `movies`.`movies` (`title`, `director_id`, `copyright_year`, `length`, `genre_id`, `category_id`, `rating`)
VALUES ('Star Wars', '2','1985-02-03','02:10','5','1','5');
 INSERT INTO `movies`.`movies` (`title`, `director_id`, `copyright_year`, `length`, `genre_id`, `category_id`, `rating`)
VALUES ('2 men and 1/2', '3','2009-04-05','00:47','3','1','4');