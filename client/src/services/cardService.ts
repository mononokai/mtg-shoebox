import type { Card } from '../types/Card'

export async function fetchCards(query: string): Promise<Card[]> {
  const res = await fetch(`/api/cards?q=${query}`);

  // Check for HTTP errors
  if (!res.ok) {
    throw new Error(`Server error (${res.status})`);
  }

  return res.json();
}