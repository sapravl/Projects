install.packages("readxl")
install.packages("GGally")

library(readxl)
library(dplyr)
library(tidyverse)
library(ggplot2)
library(GGally)

covid <- read_excel("C:/Users/peter/OneDrive/BANA/Classes/BANA 6043 - Statistical Computing/Project/Datasets/owid-covid-data-1.xlsx")
covidr1 <- covid %>%
           filter(!is.na(continent)) %>%
            filter(date=="2021-01-01")

model_cases_popden <- lm(total_cases_per_million ~ population_density, covidr1)
summary(model_cases_popden)

ggpairs(covidr1 %>% select(total_cases_per_million, perc_aged_65_older, total_deaths_per_million, population_density))

ggpairs(covidr1 %>% select(total_cases_per_million, total_deaths_per_million, perc_aged_65_older,  gdp_per_capita))