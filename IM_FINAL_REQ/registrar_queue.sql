CREATE DATABASE IF NOT EXISTS `registrar_queue`
  DEFAULT CHARACTER SET utf8mb4
  COLLATE utf8mb4_general_ci;

USE `registrar_queue`;

CREATE TABLE IF NOT EXISTS `tickets` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `ticket_no` VARCHAR(20) NOT NULL,
  `sequence` INT(11) NOT NULL,
  `service` VARCHAR(50) NOT NULL,
  `student_id` VARCHAR(50) NOT NULL,
  `window_no` INT(11) NOT NULL DEFAULT 0,
  `status` ENUM('waiting_reg','serving_reg','waiting_cash','serving_cash','done','skipped') NOT NULL DEFAULT 'waiting_reg',
  `issued_at` DATETIME NOT NULL,
  `called_at` DATETIME DEFAULT NULL,
  `concern` VARCHAR(255) DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `ratings` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `ticket_id` INT(11) DEFAULT NULL,
  `ticket_no` VARCHAR(20) DEFAULT NULL,
  `score` INT(11) DEFAULT NULL,
  `created_at` DATETIME DEFAULT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

CREATE TABLE IF NOT EXISTS `appointments` (
  `id` INT(11) NOT NULL AUTO_INCREMENT,
  `student_id` VARCHAR(50) NOT NULL,
  `service` VARCHAR(50) NOT NULL,
  `appt_date` DATE NOT NULL,
  `appt_time` VARCHAR(20) NOT NULL,
  `created_at` DATETIME NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;
