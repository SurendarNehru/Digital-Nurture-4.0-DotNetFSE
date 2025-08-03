import { render, screen } from '@testing-library/react';
import App from './App';

test('renders Flight Ticket Booking App heading', () => {
  render(<App />);
  const headingElement = screen.getByText(/Flight Ticket Booking App/i);
  expect(headingElement).toBeInTheDocument();
});
