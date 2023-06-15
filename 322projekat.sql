-- phpMyAdmin SQL Dump
-- version 5.1.0
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: Jan 23, 2022 at 09:50 PM
-- Server version: 10.4.18-MariaDB
-- PHP Version: 8.0.3

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `322projekat`
--

-- --------------------------------------------------------

--
-- Table structure for table `fooditem`
--

CREATE TABLE `fooditem` (
  `foodId` int(11) NOT NULL,
  `restorantId` int(11) NOT NULL,
  `price` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `description` varchar(50) NOT NULL,
  `type` varchar(20) NOT NULL,
  `photoDir` varchar(30) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `fooditem`
--

INSERT INTO `fooditem` (`foodId`, `restorantId`, `price`, `name`, `description`, `type`, `photoDir`) VALUES
(1, 1, 500, 'Mushroom pizza', 'Toppings: mushrooms, tomatos, cheese and salami', 'Pizza', 'pizza2.jpg'),
(2, 1, 650, 'Cheese pizza', 'Toppings: american cheese', 'Pizza', 'pizza3.png'),
(3, 1, 700, 'Pepperoni pizza', 'Toppings: pepperoni and cheese', 'Pizza', 'pizza4.png'),
(4, 1, 900, 'Vegetarian pizza', 'Toppings: vegetables', 'Pizza', 'pizza5.png'),
(5, 1, 600, 'Mixed pizza', 'Toppings: pepperoni/vegetables', 'Pizza', 'pizza6.png'),
(9, 2, 750, 'Clasic Burger', '300g meat, pickles, cheese, sauce', 'Burger', 'burger1.jpg'),
(10, 2, 850, 'Double Cheeseburger', '400g meat, lettuce, tomatos, cheese', 'Burger', 'burger2.jpg'),
(11, 2, 1000, 'Vegeterian burger', '200g vegan meat, vegetables', 'Burger', 'burger3.jpg'),
(12, 2, 300, 'Fries', '100g fries, salted', 'Fries', 'fries.jpg'),
(13, 2, 150, 'Coca Cola', '500ml bottle of soda', 'Drink', 'cocacola.png'),
(14, 2, 100, 'Fanta', '250ml can of soda', 'Drink', 'fanta.png'),
(15, 5, 699, 'Turkey Ramen', 'Ramen with eggs, turkey meat and more', 'Ramen', 'ramen1.jpg'),
(16, 5, 849, 'Vegetarian ramen', 'All ingrediants are vegeterian', 'Ramen', 'ramen2.jpg'),
(17, 5, 350, 'Fried rice', 'Rice with vegetables and chicken', 'Rice', 'fr_rice.jpg'),
(18, 5, 1299, 'Sichuan boiled fish', 'Fish', 'Fish', 'sichuan_boiled_fish.jpg'),
(19, 5, 850, 'Chow Mein', 'Chicken meat 450g', 'Ramen', 'chow_mein.jpg'),
(20, 5, 700, 'Dim Sum', 'Portion of 5, 2 sauces included', 'Ramen', 'dim_sum.jpg'),
(21, 2, 900, 'Chicken Burger', '200g chicken mean, mayo, pickles', 'Burger', 'chBurger.jpg'),
(22, 5, 150, 'Coca Cola', '500ml bottle', 'Drink', 'cocacola.png');

-- --------------------------------------------------------

--
-- Table structure for table `order`
--

CREATE TABLE `order` (
  `orderId` int(11) NOT NULL,
  `userId` int(11) NOT NULL,
  `restorantName` varchar(40) NOT NULL,
  `price` int(11) NOT NULL,
  `time` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `order`
--

INSERT INTO `order` (`orderId`, `userId`, `restorantName`, `price`, `time`) VALUES
(4, 1, 'Italian Pizzeria', 1850, '2022-01-22 23:14:37'),
(5, 1, 'Italian Pizzeria', 1150, '2022-01-22 23:15:41'),
(6, 1, 'Italian Pizzeria', 900, '2022-01-22 23:15:50'),
(7, 1, 'Italian Pizzeria', 2700, '2022-01-22 23:37:05'),
(8, 1, 'Italian Pizzeria', 500, '2022-01-22 23:37:15'),
(9, 1, 'Italian Pizzeria', 1300, '2022-01-22 23:37:21'),
(10, 1, 'BurgerShop', 1300, '2022-01-23 04:19:02'),
(11, 1, 'BurgerShop', 500, '2022-01-23 19:12:53'),
(12, 1, 'Italian Pizzeria', 1850, '2022-01-23 20:30:10'),
(13, 1, 'Italian Pizzeria', 1850, '2022-01-23 20:34:26'),
(14, 1, 'Italian Pizzeria', 1850, '2022-01-23 20:34:36'),
(15, 1, 'BurgerShop', 1300, '2022-01-23 21:20:57');

-- --------------------------------------------------------

--
-- Table structure for table `restorant`
--

CREATE TABLE `restorant` (
  `restorantId` int(11) NOT NULL,
  `name` varchar(30) NOT NULL,
  `foodType` varchar(20) NOT NULL,
  `photoDir` varchar(40) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `restorant`
--

INSERT INTO `restorant` (`restorantId`, `name`, `foodType`, `photoDir`) VALUES
(1, 'Italian Pizzeria', 'Pizza🍕', 'pizza.jpg'),
(2, 'BurgerShop', 'Burgers🍔', 'burgeri.jpg'),
(5, 'Měiwèi de', 'Chineese🍜', 'chinese.jpg');

-- --------------------------------------------------------

--
-- Table structure for table `user`
--

CREATE TABLE `user` (
  `userId` int(11) NOT NULL,
  `username` text NOT NULL,
  `password` text NOT NULL,
  `email` text NOT NULL,
  `creationDate` datetime NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=utf8mb4;

--
-- Dumping data for table `user`
--

INSERT INTO `user` (`userId`, `username`, `password`, `email`, `creationDate`) VALUES
(1, 'user', 'pass', 'mail123@gmail.com', '2022-01-22 01:35:29'),
(2, 'user2', 'pass2', 'mail456@gmail.com', '2022-01-22 01:35:29'),
(3, 'user3', 'pass3', 'someEmail@gmai.com', '2022-01-22 01:48:17'),
(16, 'test', 'test', 'test', '2022-01-22 02:54:06'),
(17, 'test', 'test@', 'test', '2022-01-22 02:55:42');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `fooditem`
--
ALTER TABLE `fooditem`
  ADD PRIMARY KEY (`foodId`),
  ADD KEY `restorantId` (`restorantId`);

--
-- Indexes for table `order`
--
ALTER TABLE `order`
  ADD PRIMARY KEY (`orderId`),
  ADD KEY `userId` (`userId`);

--
-- Indexes for table `restorant`
--
ALTER TABLE `restorant`
  ADD PRIMARY KEY (`restorantId`);

--
-- Indexes for table `user`
--
ALTER TABLE `user`
  ADD PRIMARY KEY (`userId`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `fooditem`
--
ALTER TABLE `fooditem`
  MODIFY `foodId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=23;

--
-- AUTO_INCREMENT for table `order`
--
ALTER TABLE `order`
  MODIFY `orderId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=16;

--
-- AUTO_INCREMENT for table `restorant`
--
ALTER TABLE `restorant`
  MODIFY `restorantId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `user`
--
ALTER TABLE `user`
  MODIFY `userId` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=18;

--
-- Constraints for dumped tables
--

--
-- Constraints for table `fooditem`
--
ALTER TABLE `fooditem`
  ADD CONSTRAINT `fooditem_ibfk_1` FOREIGN KEY (`restorantId`) REFERENCES `restorant` (`restorantId`);

--
-- Constraints for table `order`
--
ALTER TABLE `order`
  ADD CONSTRAINT `order_ibfk_1` FOREIGN KEY (`userId`) REFERENCES `user` (`userId`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
