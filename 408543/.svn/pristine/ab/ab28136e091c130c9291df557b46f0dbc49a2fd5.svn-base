#include "delay.h"

volatile uint32_t msTicks = 0;

void SysTick_Handler(void)
{
	msTicks++;
}

void delay(uint32_t msDelay)
{
	msTicks = 0;
	while(msDelay > msTicks);
}

