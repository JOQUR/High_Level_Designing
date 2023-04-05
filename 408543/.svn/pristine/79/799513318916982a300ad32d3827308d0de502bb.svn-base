#include "delay.h"
#include <stdio.h>
#include "usart.h"


extern volatile uint32_t msTicks;

void LED_Init(GPIO_InitTypeDef* gpio_init);



int main(void)
{
	GPIO_InitTypeDef gpio_init;
	HAL_Init();
	USART_Init();
	LED_Init(&gpio_init);
	uint32_t x = 1000;
	USART_PutChar('O');
	USART_PutChar('K');
	USART_PutChar('\r');
	USART_PutChar('\n');
	USART_WriteString("Hello World!\r\n");
	char c = 'a';
	while(1)
	{
		if (USART_GetChar(&c))
			{
					// if character was received send back 'next character' in ASCII
					USART_PutChar(c + 1);
			}		
	}
	
	return 0;
}

void LED_Init(GPIO_InitTypeDef* gpio_init)
{
	__GPIOG_CLK_ENABLE();
	gpio_init->Pin = GPIO_PIN_13;
	gpio_init->Mode = GPIO_MODE_OUTPUT_PP;
	gpio_init->Pull = GPIO_NOPULL;
	gpio_init->Speed = GPIO_SPEED_LOW;
	HAL_GPIO_Init(GPIOG, gpio_init);
}



