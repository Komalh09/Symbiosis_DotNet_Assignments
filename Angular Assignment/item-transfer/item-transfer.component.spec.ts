import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ItemTransferComponent } from './item-transfer.component';

describe('ItemTransferComponent', () => {
  let component: ItemTransferComponent;
  let fixture: ComponentFixture<ItemTransferComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ItemTransferComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ItemTransferComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
