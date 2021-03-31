install.packages("tidyverse")
install.packages("haven")
install.packages("plotly")
install.packages("fpc")

library(tidyverse)
library(readxl)
require(graphics)
if(!require(devtools)) install.packages("devtools")
devtools::install_github("kassambara/factoextra")
library(factoextra)
library(fpc)
install.packages("sjPlot")
library(sjPlot)
covid <- read_excel("C:/Users/Nite0/OneDrive - University of Cincinnati/Documents/Univ of Cincinnati/BANA 6043/Final Project/owid-covid-data-1.xlsx")

new_cases_US <- covid %>%
                  filter(country=="United States")
new_cases_World <-data.frame(covid$date, covid$continent, covid$new_cases)
new_cases_World <- na.omit(new_cases_World) %>% group_by(covid.date) %>% summarise(newcases = sum(covid.new_cases))  #removes entries without data, and summarizes number of cases by date
str(new_cases_World)
point_World <- ggplot(new_cases_World) + geom_point(mapping=aes(x=covid.date, y=newcases))+ xlab("Date")+ ylab("New cases")  #point graph of 
point_World
point_US <- ggplot(new_cases_US, aes(x=date, y=new_cases)) + geom_point(mapping=aes(x=date, y=new_cases))+ xlab("Date")+ylab("New cases")
point_US

jan01 <- covid %>%
  filter(date=="2021-01-01", !is.na(continent))   #only data from January 1st, 2021, removes continent data (only country data used)

scatter_totaldeathspermil_newdeathspermil <- ggplot(jan01) + geom_point(mapping=aes(x=total_deaths_per_million, y=new_deaths_per_million, color=continent))
scatter_totaldeathspermil_newdeathspermil

scatter_totalcasespermil_popdensity <- ggplot(jan01) + geom_point(mapping=aes(x=population_density, y=total_cases_per_million, color=continent))+ggtitle("Total cases per million vs Population density, by country")+theme(plot.title= element_text(hjust=.5))+xlab("Population density")+ylab("Total cases per million")+xlim(0,2000)
scatter_totalcasespermil_popdensity 

scatter_totaldeathspermil_popdensity <- ggplot(jan01) + geom_point(mapping=aes(x=population_density, y=total_deaths_per_million, color=continent))+xlim(0,2000)
scatter_totaldeathspermil_popdensity

scatter_totaldeathspermil_aged65 <- ggplot(jan01) + geom_point(mapping=aes(x=percent_aged_65_older, y=total_deaths_per_million, color=continent))+ ggtitle("Total deaths per million vs % aged 65 & older, by country")+theme(plot.title = element_text(hjust=.5))
scatter_totaldeathspermil_aged65     

scatter_totaldeathspermil_gdp <- ggplot(jan01) + geom_point(mapping=aes(x= GDP_per_capita, y=total_deaths_per_million, color=continent))
scatter_totaldeathspermil_gdp    
scatter_totalcasespermil_gdp <- ggplot(jan01) + geom_point(mapping=aes(x=GDP_per_capita, y=total_cases_per_million, color=continent, size=total_deaths_per_million))+ggtitle("Total cases per million vs GDP per capita, by country")+theme(plot.title = element_text(hjust=.5))+xlab("GDP per capita")+ylab("Total cases per million")+xlim(0,80000)
scatter_totalcasespermil_gdp     #size based on total deaths per million



GDP_total_cases_per <- data.frame(jan01$GDP_per_capita,jan01$total_cases_per_million) #data frame with two vectors, GDP per capita and total cases per million
GDP_total_na_removed <- na.omit(GDP_total_cases_per)  #removes the entries with no data
cl_cases <- kmeans(GDP_total_na_removed, 4)  #runs the kmeans function grouping the values into four clusters
plot(GDP_total_na_removed, type="p", pch=16, col=cl_cases$cluster, xlab="GDP per capita", ylab="total cases per million", main="Total cases per million vs GDP per capita")   #plots the total cases per million vs GDP per capita, colors represent the different cluster groups


